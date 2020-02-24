using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactor
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = GetNumber();
            PrintPrimeFactor(number);
        }

        //获取输入的数据
        public static int GetNumber()
        {
            int number = 0;
            Console.WriteLine("请输入一个整数：");
            string numberStr = Console.ReadLine();
            try
            {
                number = int.Parse(numberStr);
            }
            catch (FormatException)
            {
                Console.WriteLine("输入格式有误，请重新输入！");
                number = GetNumber();
            }
            catch(OverflowException)
            {
                Console.WriteLine("输入数值超出范围，请重新输入！");
                number = GetNumber();
            }
            return number;
        }

        //求出number的素数因子并打印
        public static void PrintPrimeFactor(int number)
        {
            //小于等于1的数没有素数因子，直接退出函数
            if (number <= 1)
            {
                Console.WriteLine("小于等于1的数没有素数因子");
                return;
            }

            Console.WriteLine($"{number}的素数因子有：");
            while (number != 1)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        number /= i;
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
