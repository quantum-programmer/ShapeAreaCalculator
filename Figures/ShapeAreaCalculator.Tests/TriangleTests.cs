// TriangleTests.cs
using ShapeAreaCalculator;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 5, 6, 12)]
    [InlineData(5, 5, 5, 10.825317547305483)]
    public void CalculateArea_ValidSides_ReturnsCorrectArea(double a, double b, double c, double expectedArea)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var area = triangle.CalculateArea();

        // Assert
        Assert.Equal(expectedArea, area, 10);
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(5, 12, 13, true)]
    [InlineData(5, 5, 5, false)]
    [InlineData(3, 4, 6, false)]
    public void IsRightAngle_VariousTriangles_ReturnsCorrectResult(double a, double b, double c, bool expected)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var isRightAngle = triangle.IsRightAngle();

        // Assert
        Assert.Equal(expected, isRightAngle);
    }

    [Theory]
    [InlineData(0, 4, 5)]
    [InlineData(3, -1, 5)]
    [InlineData(1, 1, 3)]
    [InlineData(1, 2, 1)]
    public void Constructor_InvalidSides_ThrowsArgumentException(double a, double b, double c)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}