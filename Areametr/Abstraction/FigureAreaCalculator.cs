namespace Areametr.Abstraction
{
    public class FigureAreaCalculator
    {
        public static double CalculateArea(dynamic figure) 
            => figure is IFigure iFigure ? iFigure.CalculateArea() : throw new ArgumentException("Не поддерживаемая фигура");
    }
}
