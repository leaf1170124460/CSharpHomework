using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class ShapeFactory
    {
        public static IShape GetShape(string name, params double[] values)
        {
            IShape shape = null;
            switch (name)
            {
                case "Rectangle": shape = new Rectangle(values[0], values[1]); break;
                case "Square": shape = new Square(values[0]); break;
                case "Triangle": shape = new Triangle(values[0], values[1], values[2]); break;
                default: throw new Exception("形状类型异常");
            }
            return shape;
        }
    }
}
