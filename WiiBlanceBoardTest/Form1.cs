using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiimoteLib;

namespace WiiBlanceBoardTest
{
    public partial class Form1 : Form
    {
        static int SAMP_POINTS = 1000;
        Wiimote wiimote = new Wiimote();
        public double TR, TL, BR, BL, TW;
        public double TR_Cal, TL_Cal, BR_Cal, BL_Cal, TW_Cal;   //校正済みデータ

        public double TR_offset = 0.0;
        public double TL_offset = 0.0;
        public double BR_offset = 0.0;
        public double BL_offset = 0.0;
        public double TW_offset = 0.0;

        public double[] prev_values = new double[SAMP_POINTS];
        public System.Drawing.PointF[] PrevPoints = new System.Drawing.PointF[SAMP_POINTS];

        public Form1()
        {
            InitializeComponent();

            wiimote.WiimoteChanged += OnWiimoteChanged;
            wiimote.Connect();

            comboMax.SelectedIndex = 0;
            comboRange.SelectedIndex = 0;

            for (int j = 0; j < SAMP_POINTS - 1; j++)
            {
                PrevPoints[j].X = (float)((float)j / picGraph.Width * SAMP_POINTS);
                PrevPoints[j].Y = picGraph.Height;
            }
        }

        // 処理の同期化用
        private delegate void UpdateWiimoteStateDelegate(object sender, WiimoteChangedEventArgs args);

        private void OnWiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new UpdateWiimoteStateDelegate(OnWiimoteChanged), sender, e);
                return;
            }

            // バランスボード
            switch (e.WiimoteState.ExtensionType)
            {
                case ExtensionType.BalanceBoard:
                    BalanceBoardState bbs = e.WiimoteState.BalanceBoardState;

                    // 各センサ
                    TL = bbs.SensorValuesKg.TopLeft;
                    TR = bbs.SensorValuesKg.TopRight;
                    BL = bbs.SensorValuesKg.BottomLeft;
                    BR = bbs.SensorValuesKg.BottomRight;

                    TL_Cal = TL - TL_offset;
                    TR_Cal = TR - TR_offset;
                    BL_Cal = BL - BL_offset;    
                    BR_Cal = BR - BR_offset;

                    TopLeft.Text = TL_Cal.ToString();
                    TopRight.Text = TR_Cal.ToString();
                    BottomLeft.Text = BL_Cal.ToString();
                    BottomRight.Text = BR_Cal.ToString();

                    // 体重
                    TW = bbs.WeightKg;
                    TW_Cal = TW - TW_offset;
                    TotalWeight.Text = TW_Cal.ToString();


                    //描画処理
                    //描画先とするImageオブジェクトを作成する
                    Bitmap canvas = new Bitmap(picGraph.Width, picGraph.Height);
                    //ImageオブジェクトのGraphicsオブジェクトを作成する
                    Graphics g = Graphics.FromImage(canvas);

                    //過去のデータをシフト
                    for (int i = SAMP_POINTS; i > 1; i--)
                        PrevPoints[i - 1].Y = PrevPoints[i - 2].Y;
                    PrevPoints[0].Y = (float)(-1*(TW_Cal/200) * picGraph.Height + picGraph.Height) ;

                    for (int j=0; j<SAMP_POINTS-2; j++)
                    {
                        g.DrawLine(Pens.White, PrevPoints[j], PrevPoints[j + 1]);                            
                    }

                    //リソースを解放する
                    g.Dispose();
                    //PictureBox1に表示する
                    picGraph.Image = canvas;

                    break;

            }
        }

        private void Calibration_Click(object sender, EventArgs e)
        {
            TL_offset = TL;
            TR_offset = TR;
            BL_offset = BL;
            BR_offset = BR;
            TW_offset = TW;

        }

    }
}
