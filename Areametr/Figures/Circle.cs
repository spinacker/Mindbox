using Areametr.Abstraction;

namespace Areametr.Figures
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(radius);

            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
