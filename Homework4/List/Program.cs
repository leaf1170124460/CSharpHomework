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
            GenericList<int> list = new GenericList<int>();
            for(int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            int max = list.Head.Data, min = list.Head.Data, sum = 0;
             
            list.ForEach(i => Console.WriteLine($"The element {i+1} is: {i}"));
            list.ForEach(i => max = i > max ? i : max);
            list.ForEach(i => min = min > i ? i : min);
            list.ForEach(i => sum +=i);
            Console.WriteLine($"The maximum is: {max}");
            Console.WriteLine($"The minimum is: {min}");
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
