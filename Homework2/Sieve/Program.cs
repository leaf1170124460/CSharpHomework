using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieve
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] isPrime = GetPrimeArray(200);
            Sieve(isPrime);
            PrintPrime(isPrime);
        }

        //创建长度为size的bool数组并赋初值
        public static bool[] GetPrimeArray(int size) {
            bool[] isPrime = new bool[size];
            for(int i=2;i<size;i++)
            {
                isPrime[i] = true;
            }
            return isPrime;
        }

        //执行埃氏筛法
        static void Sieve(bool[] isPrime)
        {
            for (int i = 2; i < isPrime.Length; i++)
            {
                for (int j = 2; j * i < isPrime.Length; j++)
                {
                    isPrime[j * i] = false;
                }
            }
        }

        //打印质数
        static void PrintPrime(bool[] isPrime) {
            int count = 0;                                      //count用于控制输出格式，5个为一行
            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i] == false)
                {
                    continue;
                }
				
				count++;
				Console.Write($"{i}\t");
                if (count % 5 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.Write("\n");
        }
    }
}
