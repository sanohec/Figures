using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : IFigure
    {
        private string name = "";
        private double radius;

        public Circle(double r)
        {

            R = r;
        }

        public Circle(string n, double r) : this(r)
        {
            name = n;
        }

        public double R
        {
            get
            {
                return radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус круга не может быть меньше или равен 0", nameof(value));
                }
                radius = value;
            }
        }

        public double CalculatePerimeter()
        {
            double l = (2 * Math.PI * radius);
            return l;
        }

        public double CalculateArea()
        {
            double s = Math.PI * Math.Pow(radius, 2);
            return s;
        }
    }
}
