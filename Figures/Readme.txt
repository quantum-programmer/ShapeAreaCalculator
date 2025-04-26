Объяснение архитектуры

    Интерфейс IShape:

        Базовый интерфейс для всех фигур

        Определяет метод CalculateArea()

        Позволяет работать с фигурами полиморфно

    Интерфейс IRightAngleCheckable:

        Опциональный интерфейс для фигур, которые могут быть прямоугольными

        Позволяет проверять прямоугольность без привязки к конкретному типу

    Классы фигур:

        Каждая фигура в своем классе

        Инкапсулирует логику валидации параметров

        Реализует вычисление площади

    ShapeFactory:

        Паттерн "Фабрика" для создания фигур

        Централизованное место создания объектов

        Упрощает добавление новых фигур

    AreaCalculatorService:

        Сервис для вычисления площади без знания конкретного типа

        Реализует принцип "открытости/закрытости" (Open/Closed Principle)

Как добавить новую фигуру

    Создать новый класс, реализующий IShape (и при необходимости IRightAngleCheckable)

    Добавить метод создания в ShapeFactory

    Добавить юнит-тесты
	

Пример добавления квадрата:

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

И добавить в фабрику:

// ShapeFactory.cs (дополнение)
public IShape CreateSquare(double side) => new Shapes.Square(side);


Как использовать библиотеку:

// Пример использования
var factory = new ShapeFactory();
var calculator = new AreaCalculatorService();

// Создаем фигуры
var circle = factory.CreateCircle(5);
var triangle = factory.CreateTriangle(3, 4, 5);

// Вычисляем площади без знания конкретного типа
var circleArea = calculator.CalculateArea(circle);
var triangleArea = calculator.CalculateArea(triangle);

// Проверяем, прямоугольный ли треугольник
if (triangle is IRightAngleCheckable rightAngleCheckable)
{
    var isRightAngle = rightAngleCheckable.IsRightAngle();
}


Преимущества данного подхода

    Расширяемость:

        Легко добавить новую фигуру без изменения существующего кода

        Соответствует принципу открытости/закрытости (OCP)

    Гибкость:

        Можно работать с фигурами через интерфейс IShape

        Возможность проверки прямоугольности через IRightAngleCheckable

    Тестируемость:

        Каждый компонент изолирован и легко тестируется

        Mock-объекты можно создавать на основе интерфейсов

    Чистая архитектура:

        Разделение ответственностей

        Низкая связанность компонентов

Такой подход обеспечивает хороший баланс между простотой использования и гибкостью архитектуры, что важно для библиотеки, поставляемой внешним клиентам.