using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class FormGeyleyTree : Form
    {
        private Graphics graphics;
        private double per1;                    //右分支长度比
        private double per2;                    //左分支长度比
        private double th1;                     //右分支角度
        private double th2;                     //左分支角度
        private Pen pen;                        //钢笔颜色
        private double th;                      //角度

        public FormGeyleyTree()
        {
            InitializeComponent();
            pen = Pens.Black;                                           //钢笔颜色默认为黑色
            lblTh1Value.DataBindings.Add("Text", trbTh1, "Value");      //Label绑定TrackBar数据
            lblTh2Value.DataBindings.Add("Text", trbTh2, "Value");
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int n = (int)nudN.Value;                                //递归深度
            double leng;                                            //主干长度
            double x0 = pnlGraphics.Width /2;                       //初始x坐标
            double y0 = pnlGraphics.Height - 10;                    //初始y坐标
            Double.TryParse(txtLeng.Text,out leng);
            Double.TryParse(txtPer1.Text, out per1);
            Double.TryParse(txtPer2.Text, out per2);
            th1 = trbTh1.Value * Math.PI / 180;
            th2 = trbTh2.Value * Math.PI / 180;
            th = -Math.PI / 2;

            if (graphics == null)
            {
                graphics = this.pnlGraphics.CreateGraphics();       //创建Graphics
            }
            graphics.Clear(Color.White);                            //清除原有Cayley树

            DrawCayleyTree(n, x0, y0, leng, th);                    
        }

        //绘制Cayley树
        private void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) {
                return;
            }

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        //颜色处理函数
        private void rdo_Changed(object sender, EventArgs e)
        {
            if (rdoRed.Checked)
            {
                pen = Pens.Red;
            }
            else if (rdoGreen.Checked)
            {
                pen = Pens.Green;
            }
            else if (rdoBlue.Checked)
            {
                pen = Pens.Blue;
            }
            else
            {
                pen = Pens.Black;
            }
        }
    }
}
