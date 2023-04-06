using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : IFigure
    {
        private double _radius;

        public Circle(double r)
        {
            R = r;
        }

        public double R
        {
            get
            {
                return _radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус круга не может быть меньше или равен 0", nameof(value));
                }
                _radius = value;
            }
        }

        public double CalculatePerimeter()
        {
            double l = (2 * Math.PI * _radius);
            return l;
        }

        public double CalculateArea()
        {
            double s = Math.PI * Math.Pow(_radius, 2);
            return s;
        }
    }
}
