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
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            for (Node<int> node = intlist.Head;
                  node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            for (Node<string> node = strList.Head;
                    node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

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
