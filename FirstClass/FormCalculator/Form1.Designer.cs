namespace FormCalculator
{
    partial class Form1
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
            this.firstNumDesc = new System.Windows.Forms.Label();
            this.operatorDesc = new System.Windows.Forms.Label();
            this.secondNumDesc = new System.Windows.Forms.Label();
            this.resultDesc = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.operatorBox = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumDesc
            // 
            this.firstNumDesc.AutoSize = true;
            this.firstNumDesc.Location = new System.Drawing.Point(12, 82);
            this.firstNumDesc.Name = "firstNumDesc";
            this.firstNumDesc.Size = new System.Drawing.Size(97, 15);
            this.firstNumDesc.TabIndex = 0;
            this.firstNumDesc.Text = "第一操作数：";
            this.firstNumDesc.Click += new System.EventHandler(this.firstNumDesc_Click);
            // 
            // operatorDesc
            // 
            this.operatorDesc.AutoSize = true;
            this.operatorDesc.Location = new System.Drawing.Point(12, 113);
            this.operatorDesc.Name = "operatorDesc";
            this.operatorDesc.Size = new System.Drawing.Size(97, 15);
            this.operatorDesc.TabIndex = 1;
            this.operatorDesc.Text = "第二操作数：";
            // 
            // secondNumDesc
            // 
            this.secondNumDesc.AutoSize = true;
            this.secondNumDesc.Location = new System.Drawing.Point(39, 146);
            this.secondNumDesc.Name = "secondNumDesc";
            this.secondNumDesc.Size = new System.Drawing.Size(67, 15);
            this.secondNumDesc.TabIndex = 2;
            this.secondNumDesc.Text = "运算符：";
            // 
            // resultDesc
            // 
            this.resultDesc.AutoSize = true;
            this.resultDesc.Location = new System.Drawing.Point(12, 212);
            this.resultDesc.Name = "resultDesc";
            this.resultDesc.Size = new System.Drawing.Size(0, 15);
            this.resultDesc.TabIndex = 3;
            this.resultDesc.Click += new System.EventHandler(this.resultDesc_Click);
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(239, 141);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(170, 25);
            this.computeButton.TabIndex = 4;
            this.computeButton.Text = "计算";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(112, 79);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(297, 25);
            this.firstNum.TabIndex = 5;
            this.firstNum.TextChanged += new System.EventHandler(this.firstNum_TextChanged);
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(112, 110);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(297, 25);
            this.secondNum.TabIndex = 6;
            this.secondNum.TextChanged += new System.EventHandler(this.secondNum_TextChanged);
            // 
            // operatorBox
            // 
            this.operatorBox.FormattingEnabled = true;
            this.operatorBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operatorBox.Location = new System.Drawing.Point(112, 141);
            this.operatorBox.Name = "operatorBox";
            this.operatorBox.Size = new System.Drawing.Size(121, 23);
            this.operatorBox.TabIndex = 7;
            this.operatorBox.Text = "请选择运算符";
            this.operatorBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(156, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(96, 28);
            this.title.TabIndex = 8;
            this.title.Text = "计算器";
            this.title.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 250);
            this.Controls.Add(this.title);
            this.Controls.Add(this.operatorBox);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.resultDesc);
            this.Controls.Add(this.secondNumDesc);
            this.Controls.Add(this.operatorDesc);
            this.Controls.Add(this.firstNumDesc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumDesc;
        private System.Windows.Forms.Label operatorDesc;
        private System.Windows.Forms.Label secondNumDesc;
        private System.Windows.Forms.Label resultDesc;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.ComboBox operatorBox;
        private System.Windows.Forms.Label title;
    }
}

