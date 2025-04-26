// AreaCalculatorService.cs
namespace ShapeAreaCalculator;

/// <summary>
/// Сервис для вычисления площади фигур
/// </summary>
public class AreaCalculatorService
{
    /// <summary>
    /// Вычисляет площадь фигуры без знания конкретного типа в compile-time
    /// </summary>
    public double CalculateArea(IShape shape) => shape.CalculateArea();
}