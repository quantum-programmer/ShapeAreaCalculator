// CircleTests.cs
using ShapeAreaCalculator;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(5, 78.53981633974483)]
    [InlineData(0.5, 0.7853981633974483)]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea(double radius, double expectedArea)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        var area = circle.CalculateArea();

        // Assert
        Assert.Equal(expectedArea, area);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-0.0001)]
    public void Constructor_InvalidRadius_ThrowsArgumentException(double radius)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}