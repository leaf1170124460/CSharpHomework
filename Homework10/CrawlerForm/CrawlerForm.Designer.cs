namespace CrawlerForm
{
    partial class Form
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
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lsbMain = new System.Windows.Forms.ListBox();
            this.lsbParallel = new System.Windows.Forms.ListBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblMain = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlp.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Controls.Add(this.btnStart, 2, 0);
            this.tlp.Controls.Add(this.lblUrl, 0, 0);
            this.tlp.Controls.Add(this.txtUrl, 1, 0);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 1;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.Size = new System.Drawing.Size(926, 64);
            this.tlp.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(844, 12);
            this.btnStart.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(70, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(28, 23);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(35, 18);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUrl.Location = new System.Drawing.Point(103, 18);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(718, 28);
            this.txtUrl.TabIndex = 0;
            // 
            // lsbMain
            // 
            this.lsbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbMain.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbMain.FormattingEnabled = true;
            this.lsbMain.ItemHeight = 20;
            this.lsbMain.Location = new System.Drawing.Point(3, 29);
            this.lsbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsbMain.Name = "lsbMain";
            this.lsbMain.Size = new System.Drawing.Size(457, 486);
            this.lsbMain.TabIndex = 3;
            // 
            // lsbParallel
            // 
            this.lsbParallel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbParallel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbParallel.FormattingEnabled = true;
            this.lsbParallel.ItemHeight = 20;
            this.lsbParallel.Location = new System.Drawing.Point(466, 28);
            this.lsbParallel.Name = "lsbParallel";
            this.lsbParallel.Size = new System.Drawing.Size(457, 488);
            this.lsbParallel.TabIndex = 4;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lsbMain, 0, 1);
            this.tlpMain.Controls.Add(this.lsbParallel, 1, 1);
            this.tlpMain.Controls.Add(this.lblMain, 0, 0);
            this.tlpMain.Controls.Add(this.label2, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 64);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpMain.Size = new System.Drawing.Size(926, 519);
            this.tlpMain.TabIndex = 5;
            // 
            // lblMain
            // 
            this.lblMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(200, 3);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(62, 18);
            this.lblMain.TabIndex = 5;
            this.lblMain.Text = "Normal";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parallel";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 583);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.tlp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form";
            this.Text = "Crawler";
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ListBox lsbMain;
        private System.Windows.Forms.ListBox lsbParallel;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label label2;
    }
}

