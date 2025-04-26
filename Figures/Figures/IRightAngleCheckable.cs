// IRightAngleCheckable.cs
namespace ShapeAreaCalculator;

/// <summary>
/// Интерфейс для фигур, которые могут быть прямоугольными
/// </summary>
public interface IRightAngleCheckable
{
    /// <summary>
    /// Проверяет, является ли фигура прямоугольной
    /// </summary>
    bool IsRightAngle();
}