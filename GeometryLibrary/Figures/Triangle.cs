using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Figures
{
    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        // Метод вычисления площади (GetArea лучшее название?)
        public double CalculateArea()
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
        }

        // Метод проверки прямоугольного треугольника
        public bool IsRightTriangle()
        {
            return Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                   Math.Pow(side1, 2) + Math.Pow(side3, 2) == Math.Pow(side2, 2) ||
                   Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2);
        }
    }
}
