using Areametr.Abstraction;

namespace Areametr.Figures
{
    public class Square : IFigure
    {
        private double side;

        public Square(double side)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(side);
            this.side = side;
        }

        public double CalculateArea()
        {
            return side * side;
        }
    }
}
