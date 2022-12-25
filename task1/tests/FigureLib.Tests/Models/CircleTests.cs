namespace FigureLib.Tests.Models;

public class CircleTests
{
    [Fact]
    public void Constructor_NegativeRadius_ThrowArgumentException()
    {
        var radius = -1;
        Action act = () => new Circle(radius);

        act.Should().Throw<ArgumentException>()
            .WithMessage(AppConstants.ErrorMessages.NegativeRadius);
    }

    [Fact]
    public void Square_PositiveRadius_ReturnsSquare()
    {
        var radius = 1.5;
        var circle = new Circle(radius);
        var expected = Math.PI * radius * radius;

        var square = circle.Square();

        square.Should().Be(expected);
    }
}
