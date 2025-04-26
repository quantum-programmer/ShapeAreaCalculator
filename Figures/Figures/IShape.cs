// IShape.cs
namespace ShapeAreaCalculator;

/// <summary>
/// Интерфейс для всех геометрических фигур
/// </summary>
public interface IShape
{
    /// <summary>
    /// Вычисляет площадь фигуры
    /// </summary>
    double CalculateArea();
}