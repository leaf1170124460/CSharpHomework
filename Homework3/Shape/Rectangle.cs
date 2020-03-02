using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle : IShape
    {
        private double height;
        private double width;

        public double Height
        {
            get { return height; }
            set { height = value >= 0 ? value : 0; }
        }

        public double Width
        {
            get { return width; }
            set { width = value >= 0 ? value : 0; }
        }

        public Rectangle(double length, double width)
        {
            Height = length;
            Width = width;
        }

        public double GetArea()
        {
            return Height * Width;
        }
    }
}
