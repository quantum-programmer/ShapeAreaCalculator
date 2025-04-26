// Triangle.cs
namespace ShapeAreaCalculator.Shapes;

public class Triangle : IShape, IRightAngleCheckable
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("All sides must be positive");

        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("The sum of any two sides must be greater than the third side");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CalculateArea()
    {
        // Формула Герона
        var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter
                         * (semiPerimeter - _sideA)
                         * (semiPerimeter - _sideB)
                         * (semiPerimeter - _sideC));
    }

    public bool IsRightAngle()
    {
        // Проверка по теореме Пифагора
        var sides = new[] { _sideA, _sideB, _sideC };
        Array.Sort(sides);

        // Проверка с учетом погрешности вычислений с плавающей точкой
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 0.0001;
    }

    private static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}