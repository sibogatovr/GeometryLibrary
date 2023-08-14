
namespace GeometryLibrary.Figures
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }

            this.radius = radius;
        }

        // Вычисление площади круга (GetArea лучшее название?)
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
    