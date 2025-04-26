// ShapeFactory.cs
namespace ShapeAreaCalculator;

/// <summary>
/// Фабрика для создания фигур
/// </summary>
public class ShapeFactory
{
    /// <summary>
    /// Создает круг
    /// </summary>
    public IShape CreateCircle(double radius) => new Shapes.Circle(radius);

    /// <summary>
    /// Создает треугольник
    /// </summary>
    public IShape CreateTriangle(double sideA, double sideB, double sideC)
        => new Shapes.Triangle(sideA, sideB, sideC);
}