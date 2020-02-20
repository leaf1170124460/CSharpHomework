using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class Form1 : Form
    {

        private double firstNumber;
        private double secondNumber;
        private string opera;

        public Form1()
        {
            InitializeComponent();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            getResult(firstNumber, secondNumber, opera);
        }

        private void firstNum_TextChanged(object sender, EventArgs e)
        {
            string a = firstNum.Text;
            firstNumber = getNumber(a);
        }

        private void secondNum_TextChanged(object sender, EventArgs e)
        {
            string b = secondNum.Text;
            secondNumber = getNumber(b);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = operatorBox.Text;
            opera = getOperator(c, secondNumber);
        }

        private double getNumber(string num)
        {
            try
            {
                double number = double.Parse(num);
                resultDesc.Text = ("");
                return number;
            }
            catch (FormatException)
            {
                resultDesc.Text = "格式错误,请重新输入";
            }
            catch (ArgumentNullException)
            {
                resultDesc.Text = "未输入操作数,请重新输入";
            }
            return 0.0;
        }

        private string getOperator(string opera, double secondNumber)
        {
            switch (opera)
            {
                case "+": break;
                case "-": break;
                case "*": break;
                case "/":
                    if (secondNumber == 0)
                    {
                        resultDesc.Text = "除数不能为0，请重新输入";
                    }
                    break;
                default: break;
            }
            return opera;
        }

        private void getResult(double firstNumber, double secondNumber, string opera)
        {
            try
            {
                switch (opera)
                {
                    case "+": resultDesc.Text = ($"运算结果为：{firstNumber}+{secondNumber} = {firstNumber + secondNumber}"); break;
                    case "-": resultDesc.Text = ($"运算结果为：{firstNumber}-{secondNumber} = {firstNumber - secondNumber}"); break;
                    case "*": resultDesc.Text = ($"运算结果为：{firstNumber}*{secondNumber} = {firstNumber * secondNumber}"); break;
                    case "/": resultDesc.Text = ($"运算结果为：{firstNumber}/{secondNumber} = {firstNumber / secondNumber}"); break;
                    default: break;
                }
            }
            catch (OverflowException)
            {
                resultDesc.Text = "操作数过大，结果溢出";
            }


        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void firstNumDesc_Click(object sender, EventArgs e)
        {

        }

        private void resultDesc_Click(object sender, EventArgs e)
        {
        }
    }
}
