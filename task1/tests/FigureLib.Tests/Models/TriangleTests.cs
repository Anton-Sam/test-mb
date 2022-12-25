namespace FigureLib.Tests.Models;

public class TriangleTests
{
    [Fact]
    public void Constructor_NegativeSide_ThrowArgumentException()
    {
        Action act = () => new Triangle(-1, 2, 2);

        act.Should().Throw<ArgumentException>()
            .WithMessage(AppConstants.ErrorMessages.NegativeTriangleSide);
    }

    [Fact]
    public void Constructor_InvalidTriangle_ThrowArgumentException()
    {
        Action act = () => new Triangle(2, 10, 2);

        act.Should().Throw<ArgumentException>()
            .WithMessage(AppConstants.ErrorMessages.InvalidTriangle);
    }

    [Fact]
    public void Square_ValidAndPositiveSides_ReturnsSquare()
    {
        var sideA = 2.0;
        var sideB = 3.0;
        var sideC = 4.0;
        var halfP = (sideA + sideB + sideC) / 2;
        var expected = Math.Sqrt(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC));
        var triangle = new Triangle(sideA, sideB, sideC);

        var square = triangle.Square();

        square.Should().Be(expected);
    }

    [Fact]
    public void IsRightTriangle_RightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRightTriangle = triangle.IsRightTriangle;

        isRightTriangle.Should().BeTrue();
    }

    [Fact]
    public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(2, 3, 4);

        var isRightTriangle = triangle.IsRightTriangle;

        isRightTriangle.Should().BeFalse();
    }
}