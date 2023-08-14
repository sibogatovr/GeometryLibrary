
namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class CircleTests
    {
        // ��������� ����� �� ���������� ���������� �������
        [Test]
        public void Circle_CalculateArea_ReturnsCorrectArea()
        {
            Circle circle = new Circle(5);
            double area = circle.CalculateArea();

            Assert.AreEqual(78.53981633974483, area);
        }

        // ��������� ����� �� ������������� �������� �������
        [Test]
        public void CalculateArea_NegativeRadius_ThrowsException()
        {
            double radius = -1;
            Circle circle = new Circle(radius);

            Assert.Throws<ArgumentException>(() => circle.CalculateArea());
        }

    }
}