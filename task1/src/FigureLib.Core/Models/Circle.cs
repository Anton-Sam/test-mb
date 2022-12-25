namespace FigureLib.Core.Models;

public class Circle : Figure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        ValidateCircle(radius);

        Radius = radius;
    }

    private void ValidateCircle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException(AppConstants.ErrorMessages.NegativeRadius);
    }

    public override double Square() => Math.PI * Radius * Radius;
}