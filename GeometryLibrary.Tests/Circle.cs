
namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class CircleTests
    {
        // Провреяет метод на правильное вычисление площади
        [Test]
        public void Circle_CalculateArea_ReturnsCorrectArea()
        {
            Circle circle = new Circle(5);
            double area = circle.CalculateArea();

            Assert.AreEqual(78.53981633974483, area);
        }

        // Проверяет метод на отрицательное значение радиуса
        [Test]
        public void CalculateArea_NegativeRadius_ThrowsException()
        {
            double radius = -1;
            Circle circle = new Circle(radius);

            Assert.Throws<ArgumentException>(() => circle.CalculateArea());
        }

    }
}