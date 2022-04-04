namespace WiiBlanceBoardTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Calibration = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Label();
            this.TopLeft = new System.Windows.Forms.Label();
            this.BottomRight = new System.Windows.Forms.Label();
            this.BottomLeft = new System.Windows.Forms.Label();
            this.TotalWeight = new System.Windows.Forms.Label();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.comboMax = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboRange = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // Calibration
            // 
            this.Calibration.Font = new System.Drawing.Font("MeiryoKe_PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Calibration.Location = new System.Drawing.Point(302, 50);
            this.Calibration.Name = "Calibration";
            this.Calibration.Size = new System.Drawing.Size(126, 29);
            this.Calibration.TabIndex = 0;
            this.Calibration.Text = "Calibration";
            this.Calibration.UseVisualStyleBackColor = true;
            this.Calibration.Click += new System.EventHandler(this.Calibration_Click);
            // 
            // TopRight
            // 
            this.TopRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopRight.Font = new System.Drawing.Font("MeiryoKe_UIGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TopRight.Location = new System.Drawing.Point(144, 12);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(126, 29);
            this.TopRight.TabIndex = 1;
            this.TopRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TopRight.UseMnemonic = false;
            // 
            // TopLeft
            // 
            this.TopLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TopLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopLeft.Font = new System.Drawing.Font("MeiryoKe_UIGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TopLeft.Location = new System.Drawing.Point(12, 12);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(126, 29);
            this.TopLeft.TabIndex = 2;
            this.TopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TopLeft.UseMnemonic = false;
            // 
            // BottomRight
            // 
            this.BottomRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BottomRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomRight.Font = new System.Drawing.Font("MeiryoKe_UIGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BottomRight.Location = new System.Drawing.Point(144, 50);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(126, 29);
            this.BottomRight.TabIndex = 3;
            this.BottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BottomRight.UseMnemonic = false;
            // 
            // BottomLeft
            // 
            this.BottomLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BottomLeft.Font = new System.Drawing.Font("MeiryoKe_UIGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BottomLeft.Location = new System.Drawing.Point(12, 50);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(126, 29);
            this.BottomLeft.TabIndex = 4;
            this.BottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BottomLeft.UseMnemonic = false;
            // 
            // TotalWeight
            // 
            this.TotalWeight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalWeight.Font = new System.Drawing.Font("MeiryoKe_UIGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TotalWeight.Location = new System.Drawing.Point(302, 12);
            this.TotalWeight.Name = "TotalWeight";
            this.TotalWeight.Size = new System.Drawing.Size(126, 29);
            this.TotalWeight.TabIndex = 5;
            this.TotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TotalWeight.UseMnemonic = false;
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picGraph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraph.Location = new System.Drawing.Point(12, 97);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(685, 227);
            this.picGraph.TabIndex = 6;
            this.picGraph.TabStop = false;
            // 
            // comboMax
            // 
            this.comboMax.FormattingEnabled = true;
            this.comboMax.Items.AddRange(new object[] {
            "120",
            "100",
            "80",
            "60",
            "40"});
            this.comboMax.Location = new System.Drawing.Point(545, 14);
            this.comboMax.Name = "comboMax";
            this.comboMax.Size = new System.Drawing.Size(100, 20);
            this.comboMax.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Max Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Range";
            // 
            // comboRange
            // 
            this.comboRange.Items.AddRange(new object[] {
            "100",
            "50",
            "20"});
            this.comboRange.Location = new System.Drawing.Point(545, 50);
            this.comboRange.Name = "comboRange";
            this.comboRange.Size = new System.Drawing.Size(100, 20);
            this.comboRange.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 336);
            this.Controls.Add(this.comboRange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMax);
            this.Controls.Add(this.picGraph);
            this.Controls.Add(this.TotalWeight);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.TopLeft);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.Calibration);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calibration;
        private System.Windows.Forms.Label TopRight;
        private System.Windows.Forms.Label TopLeft;
        private System.Windows.Forms.Label BottomRight;
        private System.Windows.Forms.Label BottomLeft;
        private System.Windows.Forms.Label TotalWeight;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.ComboBox comboMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboRange;
    }
}

