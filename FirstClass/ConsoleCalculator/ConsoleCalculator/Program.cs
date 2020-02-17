using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("计算器");
            double firstNumber = getNumber("请输入第一个操作数：");
            double secondNumber = getNumber("请输入第二个操作数：");
            string opera = getOperator("请输入运算符号（请输入 + 或 - 或 * 或 /）：", secondNumber);
            Console.WriteLine("---------------------------------");
            getResult(firstNumber, secondNumber, opera);
        }

        static double getNumber(string tip)
        {
            Console.WriteLine(tip);
            string a = Console.ReadLine();
            try
            {
                double number = double.Parse(a);
                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("格式错误,请重新输入");
                getNumber(tip);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("未输入操作数,请重新输入");
                getNumber(tip);
            }
            return 0.0;
        }

        static string getOperator(string tip, double secondNumber)
        {
            Console.WriteLine(tip);
            string opera = Console.ReadLine();
            switch (opera)
            {
                case "+": break;
                case "-": break;
                case "*": break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("除数不能为0");
                    }
                    break;
                default: getOperator(tip, secondNumber); break;
            }
            return opera;
        }

        static void getResult(double firstNumber, double secondNumber, string opera)
        {
            try
            {
                switch (opera)
                {
                    case "+": Console.WriteLine($"运算结果为：{firstNumber}+{secondNumber}={firstNumber + secondNumber}"); break;
                    case "-": Console.WriteLine($"运算结果为：{firstNumber}-{secondNumber}={firstNumber - secondNumber}"); break;
                    case "*": Console.WriteLine($"运算结果为：{firstNumber}*{secondNumber}={firstNumber * secondNumber}"); break;
                    case "/": if(secondNumber!=0) Console.WriteLine($"运算结果为：{firstNumber}/{secondNumber}={firstNumber / secondNumber}"); break;
                    default: break;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("操作数过大，结果溢出");
            }
        }
    }
}
