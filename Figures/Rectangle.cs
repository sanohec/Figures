using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : IFigure
    {
        private double _sideA;
        private double _sideB;

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double A
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше 0", nameof(value));
                }

                _sideA = value;
            }
        }

        public double B
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше 0", nameof(value));
                }

                _sideB = value;
            }
        }

        public double CalculatePerimeter()
        {
            double p = (_sideA + _sideB) * 2;
            return p;
        }

        public double CalculateArea()
        {
            double area = _sideA * _sideB;
            return area;
        }
    }
}
