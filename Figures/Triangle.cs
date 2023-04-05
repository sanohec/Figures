using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : IFigure
    {
        public string name = "";
        private double sideA;
        private double sideB;
        private double sideC;
        private int angle;

        public Triangle(double a, double b, int an)
        {
            A = a;
            B = b;
            Angle = an;
        }

        public Triangle(string n, double a, double b, int an) : this(a, b, an)
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
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника не может быть меньше или равена 0", nameof(value));
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
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника не может быть меньше или равен 0", nameof(value));
                }

                sideB = value;
            }
        }

        public double C
        {
            get
            {
                return sideC;
            }
        }

        public double Angle
        {
            get
            {
                return angle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Угол между двумя сторонами треугольника не может быть меньше или равен 0", nameof(value));
                }

                value = angle;
                CalculateC();
            }
        }

        public double CalculatePerimeter()
        {
            double p = (sideA + sideB + sideC);
            return p;
        }

        public double CalculateArea()
        {
            double s = ((sideA * sideB * Math.Sin(angle)) / 2);
            return s;
        }

        public void CalculateC()
        {
            sideC = Math.Sqrt(Math.Pow(sideB, 2) + Math.Pow(sideA, 2) - 2 * sideB * sideA * Math.Cos(angle));
        }

        public bool IsRightTriangle()
        {
            return (sideA * sideA + sideB * sideB == sideC * sideC || sideA * sideA + sideC * sideC == sideB * sideB ||sideB * sideB + sideC * sideC == sideA * sideA);                    
        }
    }
}
