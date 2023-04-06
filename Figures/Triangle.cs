using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : IFigure
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private int _angle;

        public Triangle(double a, double b, int an)
        {
            A = a;
            B = b;
            Angle = an;
        }


        public double A
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника не может быть меньше или равена 0", nameof(value));
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
                if (value <= 0)
                {
                    throw new ArgumentException("Сторона треугольника не может быть меньше или равен 0", nameof(value));
                }

                _sideB = value;
            }
        }

        public double C
        {
            get
            {
                return _sideC;
            }
        }

        public double Angle
        {
            get
            {
                return _angle;
            }
            set
            {
                if (value <= 0 || value >= 180) 
                {
                    throw new ArgumentException("Угол между двумя сторонами треугольника не может быть меньше или равен 0 или быть больше 180", nameof(value));
                }

                value = _angle;
                CalculateC();
            }
        }

        public double CalculatePerimeter()
        {
            double p = (_sideA + _sideB + _sideC);
            return p;
        }

        public double CalculateArea()
        {
            double s = ((_sideA * _sideB * Math.Sin(_angle)) / 2);
            return s;
        }

        public void CalculateC()
        {
            _sideC = Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideA, 2) - 2 * _sideB * _sideA * Math.Cos(_angle));
        }

        public bool IsRightTriangle()
        {
            return (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC || _sideA * _sideA + _sideC * _sideC == _sideB * _sideB ||_sideB * _sideB + _sideC * _sideC == _sideA * _sideA);                    
        }
    }
}
