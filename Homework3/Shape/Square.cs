using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Square : IShape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set { side = value >= 0 ? value : 0; }
        }

        public Square(double side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Side * Side;
        }
    }
}
