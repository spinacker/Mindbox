using Areametr.Abstraction;

namespace Areametr.Figures
{
    public class Triangle : IFigure
    {
        private double sideA, sideB, sideC;

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle { get; init; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            Validate(sideA, sideB, sideC);

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            IsRightTriangle = IsRight(sideA, sideB, sideC);
        }

        public double CalculateArea()
        {
            var p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        private void Validate(double a, double b, double c)
        {
            if (CheckTriangleInequality(a, b, c)
                && CheckTriangleInequality(b, a, c)
                && CheckTriangleInequality(c, b, a))
                return;
            throw new ArgumentOutOfRangeException("Не соблюдены размеры сторон");
        }

        private static bool IsRight(double a, double b, double c)
                => (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);

        public static bool CheckTriangleInequality(double a, double b, double c)
                => a < b + c;

    }
}
