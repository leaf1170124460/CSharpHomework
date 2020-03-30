namespace CayleyTree
{
    partial class FormGeyleyTree
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblN = new System.Windows.Forms.Label();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.trbTh1 = new System.Windows.Forms.TrackBar();
            this.trbTh2 = new System.Windows.Forms.TrackBar();
            this.pnlPen = new System.Windows.Forms.Panel();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblLeng = new System.Windows.Forms.Label();
            this.lblPer1 = new System.Windows.Forms.Label();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.lblTh1 = new System.Windows.Forms.Label();
            this.lblTh2 = new System.Windows.Forms.Label();
            this.lblPen = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.pnlGraphics = new System.Windows.Forms.Panel();
            this.lblTh1Value = new System.Windows.Forms.Label();
            this.lblTh2Value = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh2)).BeginInit();
            this.pnlPen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(19, 19);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(67, 15);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "递归深度";
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(137, 62);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(121, 25);
            this.txtLeng.TabIndex = 2;
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(137, 113);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(121, 25);
            this.txtPer1.TabIndex = 3;
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(137, 163);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(121, 25);
            this.txtPer2.TabIndex = 4;
            // 
            // trbTh1
            // 
            this.trbTh1.Location = new System.Drawing.Point(137, 211);
            this.trbTh1.Maximum = 360;
            this.trbTh1.Name = "trbTh1";
            this.trbTh1.Size = new System.Drawing.Size(121, 56);
            this.trbTh1.TabIndex = 5;
            this.trbTh1.TickFrequency = 60;
            // 
            // trbTh2
            // 
            this.trbTh2.Location = new System.Drawing.Point(137, 267);
            this.trbTh2.Maximum = 360;
            this.trbTh2.Name = "trbTh2";
            this.trbTh2.Size = new System.Drawing.Size(121, 56);
            this.trbTh2.TabIndex = 6;
            this.trbTh2.TickFrequency = 60;
            // 
            // pnlPen
            // 
            this.pnlPen.Controls.Add(this.rdoBlack);
            this.pnlPen.Controls.Add(this.rdoBlue);
            this.pnlPen.Controls.Add(this.rdoGreen);
            this.pnlPen.Controls.Add(this.rdoRed);
            this.pnlPen.Location = new System.Drawing.Point(137, 329);
            this.pnlPen.Name = "pnlPen";
            this.pnlPen.Size = new System.Drawing.Size(200, 142);
            this.pnlPen.TabIndex = 7;
            // 
            // rdoBlack
            // 
            this.rdoBlack.AutoSize = true;
            this.rdoBlack.Checked = true;
            this.rdoBlack.Location = new System.Drawing.Point(25, 90);
            this.rdoBlack.Name = "rdoBlack";
            this.rdoBlack.Size = new System.Drawing.Size(58, 19);
            this.rdoBlack.TabIndex = 3;
            this.rdoBlack.TabStop = true;
            this.rdoBlack.Text = "黑色";
            this.rdoBlack.UseVisualStyleBackColor = true;
            this.rdoBlack.CheckedChanged += new System.EventHandler(this.rdo_Changed);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(25, 65);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(58, 19);
            this.rdoBlue.TabIndex = 2;
            this.rdoBlue.Text = "蓝色";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdo_Changed);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(25, 40);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(58, 19);
            this.rdoGreen.TabIndex = 1;
            this.rdoGreen.Text = "绿色";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdo_Changed);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(25, 15);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(58, 19);
            this.rdoRed.TabIndex = 0;
            this.rdoRed.Text = "红色";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdo_Changed);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(137, 486);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(83, 42);
            this.btnDraw.TabIndex = 8;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // lblLeng
            // 
            this.lblLeng.AutoSize = true;
            this.lblLeng.Location = new System.Drawing.Point(19, 65);
            this.lblLeng.Name = "lblLeng";
            this.lblLeng.Size = new System.Drawing.Size(67, 15);
            this.lblLeng.TabIndex = 9;
            this.lblLeng.Text = "主干长度";
            // 
            // lblPer1
            // 
            this.lblPer1.AutoSize = true;
            this.lblPer1.Location = new System.Drawing.Point(19, 116);
            this.lblPer1.Name = "lblPer1";
            this.lblPer1.Size = new System.Drawing.Size(97, 15);
            this.lblPer1.TabIndex = 10;
            this.lblPer1.Text = "右分支长度比";
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.Location = new System.Drawing.Point(19, 166);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(97, 15);
            this.lblPer2.TabIndex = 11;
            this.lblPer2.Text = "左分支长度比";
            // 
            // lblTh1
            // 
            this.lblTh1.AutoSize = true;
            this.lblTh1.Location = new System.Drawing.Point(19, 215);
            this.lblTh1.Name = "lblTh1";
            this.lblTh1.Size = new System.Drawing.Size(82, 15);
            this.lblTh1.TabIndex = 12;
            this.lblTh1.Text = "右分支角度";
            // 
            // lblTh2
            // 
            this.lblTh2.AutoSize = true;
            this.lblTh2.Location = new System.Drawing.Point(19, 273);
            this.lblTh2.Name = "lblTh2";
            this.lblTh2.Size = new System.Drawing.Size(82, 15);
            this.lblTh2.TabIndex = 13;
            this.lblTh2.Text = "左分支角度";
            // 
            // lblPen
            // 
            this.lblPen.AutoSize = true;
            this.lblPen.Location = new System.Drawing.Point(19, 329);
            this.lblPen.Name = "lblPen";
            this.lblPen.Size = new System.Drawing.Size(67, 15);
            this.lblPen.TabIndex = 14;
            this.lblPen.Text = "画笔颜色";
            // 
            // nudN
            // 
            this.nudN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudN.Location = new System.Drawing.Point(138, 17);
            this.nudN.Name = "nudN";
            this.nudN.ReadOnly = true;
            this.nudN.Size = new System.Drawing.Size(120, 25);
            this.nudN.TabIndex = 16;
            // 
            // pnlGraphics
            // 
            this.pnlGraphics.Location = new System.Drawing.Point(365, 29);
            this.pnlGraphics.Name = "pnlGraphics";
            this.pnlGraphics.Size = new System.Drawing.Size(735, 538);
            this.pnlGraphics.TabIndex = 17;
            // 
            // lblTh1Value
            // 
            this.lblTh1Value.AutoSize = true;
            this.lblTh1Value.Location = new System.Drawing.Point(264, 215);
            this.lblTh1Value.Name = "lblTh1Value";
            this.lblTh1Value.Size = new System.Drawing.Size(15, 15);
            this.lblTh1Value.TabIndex = 18;
            this.lblTh1Value.Text = "0";
            // 
            // lblTh2Value
            // 
            this.lblTh2Value.AutoSize = true;
            this.lblTh2Value.Location = new System.Drawing.Point(264, 273);
            this.lblTh2Value.Name = "lblTh2Value";
            this.lblTh2Value.Size = new System.Drawing.Size(15, 15);
            this.lblTh2Value.TabIndex = 19;
            this.lblTh2Value.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.lblTh2Value);
            this.panel1.Controls.Add(this.lblN);
            this.panel1.Controls.Add(this.lblTh1Value);
            this.panel1.Controls.Add(this.lblLeng);
            this.panel1.Controls.Add(this.lblPer1);
            this.panel1.Controls.Add(this.txtLeng);
            this.panel1.Controls.Add(this.pnlPen);
            this.panel1.Controls.Add(this.nudN);
            this.panel1.Controls.Add(this.lblPer2);
            this.panel1.Controls.Add(this.txtPer1);
            this.panel1.Controls.Add(this.trbTh2);
            this.panel1.Controls.Add(this.lblPen);
            this.panel1.Controls.Add(this.lblTh1);
            this.panel1.Controls.Add(this.txtPer2);
            this.panel1.Controls.Add(this.trbTh1);
            this.panel1.Controls.Add(this.lblTh2);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 538);
            this.panel1.TabIndex = 20;
            // 
            // FormGeyleyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 597);
            this.Controls.Add(this.pnlGraphics);
            this.Controls.Add(this.panel1);
            this.Name = "FormGeyleyTree";
            this.Text = "GeyleyTree";
            ((System.ComponentModel.ISupportInitialize)(this.trbTh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTh2)).EndInit();
            this.pnlPen.ResumeLayout(false);
            this.pnlPen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.TrackBar trbTh1;
        private System.Windows.Forms.TrackBar trbTh2;
        private System.Windows.Forms.Panel pnlPen;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblLeng;
        private System.Windows.Forms.Label lblPer1;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.Label lblTh1;
        private System.Windows.Forms.Label lblTh2;
        private System.Windows.Forms.Label lblPen;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Panel pnlGraphics;
        private System.Windows.Forms.Label lblTh1Value;
        private System.Windows.Forms.Label lblTh2Value;
        private System.Windows.Forms.Panel panel1;
    }
}

