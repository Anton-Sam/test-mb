namespace FigureLib.Core.Models;

public class Triangle : Figure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    public double Perimeter => SideA + SideB + SideC;
    public bool IsRightTriangle =>
        SideC * SideC == SideA * SideA + SideB * SideB ||
        SideB * SideB == SideA * SideA + SideC * SideC ||
        SideA * SideA == SideB * SideB + SideC * SideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        ValidateTriangle(sideA, sideB, sideC);

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private void ValidateTriangle(double sideA, double sideB, double sideC)
    {
        if (sideA < 0 || sideB < 0 || sideC < 0)
            throw new ArgumentException(AppConstants.ErrorMessages.NegativeTriangleSide);

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException(AppConstants.ErrorMessages.InvalidTriangle);
    }

    public override double Square()
    {
        var halfP = Perimeter / 2;
        var square = Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));

        return square;
    }
}