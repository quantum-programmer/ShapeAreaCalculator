���������� �����������

    ��������� IShape:

        ������� ��������� ��� ���� �����

        ���������� ����� CalculateArea()

        ��������� �������� � �������� ����������

    ��������� IRightAngleCheckable:

        ������������ ��������� ��� �����, ������� ����� ���� ��������������

        ��������� ��������� ��������������� ��� �������� � ����������� ����

    ������ �����:

        ������ ������ � ����� ������

        ������������� ������ ��������� ����������

        ��������� ���������� �������

    ShapeFactory:

        ������� "�������" ��� �������� �����

        ���������������� ����� �������� ��������

        �������� ���������� ����� �����

    AreaCalculatorService:

        ������ ��� ���������� ������� ��� ������ ����������� ����

        ��������� ������� "����������/����������" (Open/Closed Principle)

��� �������� ����� ������

    ������� ����� �����, ����������� IShape (� ��� ������������� IRightAngleCheckable)

    �������� ����� �������� � ShapeFactory

    �������� ����-�����
	

������ ���������� ��������:

// Square.cs
namespace ShapeAreaCalculator.Shapes;

public class Square : IShape
{
    private readonly double _side;

    public Square(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side must be positive", nameof(side));
        
        _side = side;
    }

    public double CalculateArea() => Math.Pow(_side, 2);
}

� �������� � �������:

// ShapeFactory.cs (����������)
public IShape CreateSquare(double side) => new Shapes.Square(side);


��� ������������ ����������:

// ������ �������������
var factory = new ShapeFactory();
var calculator = new AreaCalculatorService();

// ������� ������
var circle = factory.CreateCircle(5);
var triangle = factory.CreateTriangle(3, 4, 5);

// ��������� ������� ��� ������ ����������� ����
var circleArea = calculator.CalculateArea(circle);
var triangleArea = calculator.CalculateArea(triangle);

// ���������, ������������� �� �����������
if (triangle is IRightAngleCheckable rightAngleCheckable)
{
    var isRightAngle = rightAngleCheckable.IsRightAngle();
}


������������ ������� �������

    �������������:

        ����� �������� ����� ������ ��� ��������� ������������� ����

        ������������� �������� ����������/���������� (OCP)

    ��������:

        ����� �������� � �������� ����� ��������� IShape

        ����������� �������� ��������������� ����� IRightAngleCheckable

    �������������:

        ������ ��������� ���������� � ����� �����������

        Mock-������� ����� ��������� �� ������ �����������

    ������ �����������:

        ���������� ����������������

        ������ ����������� �����������

����� ������ ������������ ������� ������ ����� ��������� ������������� � ��������� �����������, ��� ����� ��� ����������, ������������ ������� ��������.