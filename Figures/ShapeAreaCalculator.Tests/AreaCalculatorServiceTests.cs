// AreaCalculatorServiceTests.cs
using ShapeAreaCalculator;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests;

public class AreaCalculatorServiceTests
{
    [Fact]
    public void CalculateArea_ForCircle_ReturnsCorrectArea()
    {
        // Arrange
        var service = new AreaCalculatorService();
        var circle = new Circle(5);

        // Act
        var area = service.CalculateArea(circle);

        // Assert
        Assert.Equal(78.53981633974483, area, 10);
    }

    [Fact]
    public void CalculateArea_ForTriangle_ReturnsCorrectArea()
    {
        // Arrange
        var service = new AreaCalculatorService();
        var triangle = new Triangle(3, 4, 5);

        // Act
        var area = service.CalculateArea(triangle);

        // Assert
        Assert.Equal(6, area);
    }
}