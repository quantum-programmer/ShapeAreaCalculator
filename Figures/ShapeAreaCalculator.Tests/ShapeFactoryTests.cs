// ShapeFactoryTests.cs
using ShapeAreaCalculator;

namespace ShapeAreaCalculator.Tests;

public class ShapeFactoryTests
{
    private readonly ShapeFactory _factory = new();

    [Fact]
    public void CreateCircle_ValidRadius_ReturnsCircle()
    {
        // Act
        var circle = _factory.CreateCircle(5);

        // Assert
        Assert.NotNull(circle);
    }

    [Fact]
    public void CreateTriangle_ValidSides_ReturnsTriangle()
    {
        // Act
        var triangle = _factory.CreateTriangle(3, 4, 5);

        // Assert
        Assert.NotNull(triangle);
    }
}