using System;

public class Car
{
    // Свойства
    public string LicensePlate { get; set; } // Номер авто
    public string Brand { get; set; } // Марка
    public string Color { get; set; } // Цвет
    public double CurrentSpeed { get; set; } // Текущая скорость

    // Константа для максимальной скорости.
    private const double MaxSpeed = 180.0;

    // Конструкторы

    // 1. Конструктор по умолчанию
    public Car()
    {
        LicensePlate = "Не определен";
        Brand = "Неизвестно";
        Color = "Не указан";
        CurrentSpeed = 0.0;
    }

    // 2. Конструктор с номером, маркой и цветом
    public Car(string licensePlate, string brand, string color)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Color = color;
        CurrentSpeed = 0.0;
    }

    // 3. Конструктор со всеми параметрами
    public Car(string licensePlate, string brand, string color, double currentSpeed)
    {
        LicensePlate = licensePlate;
        Brand = brand;
        Color = color;
        CurrentSpeed = currentSpeed;
    }

    // Методы

    // Езда (ускорение)
    public void Drive(double acceleration, double duration)
    {
        //duration в секундах

        if (acceleration <= 0 || duration <= 0)
        {
            Console.WriteLine("Ошибка: ускорение и время должны быть положительными.");
            return;
        }

        double newSpeed = CurrentSpeed + acceleration * duration;

        if (newSpeed > MaxSpeed)
        {
            Console.WriteLine($"Превышение максимальной скорости! Скорость ограничена до {MaxSpeed} км/ч.");
            CurrentSpeed = MaxSpeed;
        }
        else
        {
            CurrentSpeed = newSpeed;
        }

        Console.WriteLine($"Автомобиль {Brand} {LicensePlate} разгоняется. Текущая скорость: {CurrentSpeed:F2} км/ч");
    }

    // Торможение
    public void Brake()
    {
        if (CurrentSpeed > MaxSpeed)
        {
            Console.WriteLine($"Автомобиль {Brand} {LicensePlate} превысил допустимую скорость! Экстренное торможение!");
            CurrentSpeed = 0.0; // Полная остановка
        }
        else
        {
            Console.WriteLine($"Автомобиль {Brand} {LicensePlate} тормозит.");
            CurrentSpeed = Math.Max(0, CurrentSpeed - 10); // Замедление на 10 км/ч, но не ниже 0.
        }

        Console.WriteLine($"Текущая скорость: {CurrentSpeed:F2} км/ч");
    }

    // Вывод информации об автомобиле
    public void PrintInfo()
    {
        Console.WriteLine($"Номер: {LicensePlate}");
        Console.WriteLine($"Марка: {Brand}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Текущая скорость: {CurrentSpeed:F2} км/ч");
    }
}

public class CarExample
{
    public static void Main(string[] args)
    {
        // Создание автомобилей с разными конструкторами
        Car car1 = new Car();
        Console.WriteLine("Информация об car1:");
        car1.PrintInfo();

        Car car2 = new Car("AA123BB", "Toyota", "Red");
        Console.WriteLine("\nИнформация об car2:");
        car2.PrintInfo();

        Car car3 = new Car("CC456DD", "BMW", "Blue", 50.0);
        Console.WriteLine("\nИнформация об car3:");
        car3.PrintInfo();

        // Демонстрация методов

        Console.WriteLine("\ncar2 едет:");
        car2.Drive(5.0, 10.0); // Ускорение 5 м/с^2 в течение 10 секунд
        car2.PrintInfo();

        Console.WriteLine("\ncar3 едет:");
        car3.Drive(10.0, 20.0); // Разгон до превышения макс. скорости
        car3.PrintInfo();

        Console.WriteLine("\ncar3 тормозит:");
        car3.Brake();
        car3.PrintInfo();

        Console.WriteLine("\ncar2 тормозит:");
        car2.Brake();
        car2.PrintInfo();
    }
}
