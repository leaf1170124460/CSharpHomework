using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            int max = int.MaxValue, min = int.MinValue, sum = 0;
            list.ForEach(i => Console.WriteLine($"The element{i+1} is: {i}"));
            list.ForEach(i => max = i > max ? i : max);
            list.ForEach(i => min = min > i ? i : min);
            list.ForEach(i => sum +=i);
            Console.WriteLine($"The maximum is: {max}");
            Console.WriteLine($"The minimum is: {min}");
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
