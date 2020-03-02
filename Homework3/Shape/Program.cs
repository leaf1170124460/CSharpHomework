using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[10];
            double areaSum = 0.0;
            Random rand = new Random();

            //随机产生形状对象
            for(int i = 0; i < 10; i++)
            {
                switch (rand.Next(0,3))
                {
                    case 0: shapes[i] = ShapeFactory.GetShape("Rectangle", rand.Next(0,10), rand.Next(0, 10));break;
                    case 1: shapes[i] = ShapeFactory.GetShape("Square", rand.Next(0, 10));break;
                    case 2: shapes[i] = ShapeFactory.GetShape("Triangle", rand.Next(0, 10), rand.Next(0, 10), rand.Next(0, 10));break;
                    default: throw new Exception("随机数产生异常"); 
                }
            }

            foreach (IShape shape in shapes){
                areaSum += shape.GetArea();
            }

            Console.WriteLine($"The sum of area is: {areaSum}");
        }
    }
}
