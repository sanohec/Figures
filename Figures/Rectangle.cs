using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : IFigure
    {
        public string name = "";
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }


        public Rectangle(string n, double a, double b) : this(a, b)
        {
            name = n;
        }

        public double A
        {
            get
            {
                return sideA;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше 0", nameof(value));
                }

                sideA = value;
            }
        }

        public double B
        {
            get
            {
                return sideB;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше 0", nameof(value));
                }

                sideB = value;
            }
        }

        public double CalculatePerimeter()
        {
            double p = (sideA + sideB) * 2;
            return p;
        }

        public double CalculateArea()
        {
            double area = sideA * sideB;
            return area;
        }
    }
}
