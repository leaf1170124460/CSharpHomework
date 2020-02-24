using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array=GetArray();
            Console.WriteLine($"数组的最大值为：{GetMax(array)}");
            Console.WriteLine($"数组的最小值为：{GetMin(array)}");
            Console.WriteLine($"数组的和为：{GetSum(array)}");
            Console.WriteLine($"数组的平均值为：{GetAverage(array)}");
        }

        //创建数组
        public static int[] GetArray()
        {
            //输入数组的元素个数并创建数组
            int size = 1;
            do
            {
                Console.WriteLine("请输入数组的元素个数（大于等于1的整数）：");
                string sizeStr = Console.ReadLine();
                try
                {
                    size = int.Parse(sizeStr);
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入格式有误，请重新输入！");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("输入数值超出范围，请重新输入！");
                }
            } while (size <= 0);
            int[] array = new int[size];

            //输入数组的元素
            string elementStr = "";
            int element = 0;
            int i = 0;
            Console.WriteLine("请输入数组的元素：");
            while (i < size)
            {
                Console.WriteLine($"请输入第{i+1}个整数：");
                elementStr = Console.ReadLine();
                try
                {
                    element = int.Parse(elementStr);
                    array[i] = element;
                    i++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("输入格式有误，请重新输入！");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("输入数值超出范围，请重新输入！");
                }
            }
            return array;
        }

        //获取array的最大值
        public static int GetMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = array[i]>max?array[i]:max;
            }
            return max;
        }

        //获取array的最小值
        public static int GetMin(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                min = array[i]<min?array[i]:min;
            }
            return min;
        }

        //获取array的和
        public static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        //获取array的平均值
        public static double GetAverage(int[] array)
        {
            int sum = GetSum(array);
            return (double)sum / array.Length;
        }
    }
}
