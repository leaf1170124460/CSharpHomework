using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Triangle : IShape
    {
        private double firstLine;
        private double secondLine;
        private double thirdLine;

        public double FirstLine
        {
            get { return firstLine; }
            set { firstLine = value >= 0 ? value : 0; }
        }

        public double SecondLine
        {
            get { return secondLine; }
            set { secondLine = value >= 0 ? value : 0; }
        }

        public double ThirdLine
        {
            get { return thirdLine; }
            set { thirdLine = value >= 0 ? value : 0; }
        }

        public Triangle(double firstLine, double secondLine, double thirdLine)
        {
            if (firstLine + secondLine > thirdLine && firstLine + thirdLine > secondLine && secondLine + thirdLine > firstLine)
            {
                FirstLine = firstLine;
                SecondLine = secondLine;
                ThirdLine = thirdLine;
            }
        }

        public double GetArea()
        {
            double p = 0.5*(FirstLine + SecondLine + ThirdLine) ;
            return Math.Sqrt(p * (p - FirstLine) * (p - SecondLine) * (p - ThirdLine));
        }
    }
}
