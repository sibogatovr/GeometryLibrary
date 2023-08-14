namespace GeometryLibrary.Tests
{
    public class TriangleTests
    {
        // Проверяет метод IsRightTriangle() , возвращает true для правильного треугольника
        [Test]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.True(isRightTriangle);
        }

        // Проверяет метод IsRightTriangle() , возвращает false для неправильного треугольника
        [Test]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            Triangle triangle = new Triangle(2, 3, 4);
            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.False(isRightTriangle);
        }

        // Проверяет метод CalculateArea() на правильный расчет площади
        [Test]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double expectedArea = 6;
            double calculatedArea = triangle.CalculateArea();

            Assert.AreEqual(expectedArea, calculatedArea);
        }

        // Проверяет метод CalculateArea(), возвращает NaN при отрицательной стороне
        [Test]
        public void CalculateArea_NegativeSides_ReturnsNaN()
        {
            Triangle triangle = new Triangle(-3, -4, -5);
            double calculatedArea = triangle.CalculateArea();

            Assert.AreEqual(double.NaN, calculatedArea);
        }
    }
}
