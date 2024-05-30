using Areametr.Figures;

namespace Areametr.Tests
{
    [TestFixture]
    public class GeometryTests
    {
        [Test]
        public void Circle_AreaCalculation_Not_Fail()
        {
            Circle circle = new (5);
            Assert.That(circle.CalculateArea(), Is.EqualTo(78.53981633974483).Within(0.0001));
        }

        [Test]
        public void CircleCreate_InvalidRadius_ExceptionThrown()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        [Test]
        public void Triangle_AreaCalculation_Not_Fail()
        {
            Triangle triangle = new (3, 4, 5);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(6).Within(0.0001));
        }

        [Test]
        public void TriangleCreate_InvalidSides_ExceptionThrown()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 5, 5));
        }

        [Test]
        public void Triangle_IsRightTriangle_True()
        {
            Triangle triangle = new (3, 4, 5);
            Assert.That(triangle.IsRightTriangle, Is.True);
        }

        [Test]
        public void Square_AreaCalculation_Not_Fail()
        {
            Square square = new (4);
            Assert.That(square.CalculateArea(), Is.EqualTo(16).Within(0.0001));
        }

        [Test]
        public void SquareCreate_InvalidSide_ExceptionThrown()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Square(-5));
        }
    }
}