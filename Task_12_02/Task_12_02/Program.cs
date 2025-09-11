using System;

// Класс, представляющий питомца.
public class Pet
{
    // Свойства
    public string Name { get; set; } // Кличка
    public string Species { get; set; } // Вид животного
    public int Age { get; set; } // Возраст
    public double Weight { get; set; } // Вес
    public bool IsHealthy { get; set; } // Состояние здоровья (true - здоров, false - нездоров)

    // Конструкторы

    // 1. Конструктор по умолчанию.
    public Pet()
    {
        Name = "Безымянный";
        Species = "Неизвестный";
        Age = 0;
        Weight = 1.0;
        IsHealthy = true;
    }

    // 2. Конструктор с кличкой и видом животного.
    public Pet(string name, string species)
    {
        Name = name;
        Species = species;
        Age = 0;
        Weight = 1.0;
        IsHealthy = true;
    }

    // 3. Конструктор со всеми параметрами, кроме состояния здоровья.
    public Pet(string name, string species, int age, double weight)
    {
        Name = name;
        Species = species;
        Age = age;
        Weight = weight;
        IsHealthy = true;
    }

    // 4. Конструктор со всеми параметрами.
    public Pet(string name, string species, int age, double weight, bool isHealthy)
    {
        Name = name;
        Species = species;
        Age = age;
        Weight = weight;
        IsHealthy = isHealthy;
    }

    // Методы

    // Вывод информации об объекте.
    public void PrintInfo()
    {
        Console.WriteLine($"Кличка: {Name}");
        Console.WriteLine($"Вид: {Species}");
        Console.WriteLine($"Возраст: {Age} лет");
        Console.WriteLine($"Вес: {Weight} кг");
        Console.WriteLine($"Состояние здоровья: {(IsHealthy ? "Здоров" : "Не здоров")}");
    }

    // Изменение значения веса животного.
    public void SetWeight(double newWeight)
    {
        if (newWeight > 0)
        {
            Weight = newWeight;
            Console.WriteLine($"Вес {Name} изменен на {Weight} кг.");
        }
        else
        {
            Console.WriteLine("Ошибка: вес должен быть положительным числом.");
        }
    }

    // Изменение отметки о состоянии здоровья.
    public void SetHealth(bool isHealthy)
    {
        IsHealthy = isHealthy;
        Console.WriteLine($"Состояние здоровья {Name} изменено на {(IsHealthy ? "Здоров" : "Не здоров")}.");
    }
}

// Пример использования класса Pet
public class PetExample
{
    public static void Main(string[] args)
    {
        // Создание объектов с использованием разных конструкторов

        // Используем конструктор по умолчанию.
        Pet pet1 = new Pet();
        Console.WriteLine("Информация о pet1:");
        pet1.PrintInfo();

        // Используем конструктор с кличкой и видом.
        Pet pet2 = new Pet("Барсик", "Кот");
        Console.WriteLine("\nИнформация о pet2:");
        pet2.PrintInfo();

        // Используем конструктор со всеми параметрами (кроме состояния здоровья).
        Pet pet3 = new Pet("Рекс", "Собака", 3, 15.5);
        Console.WriteLine("\nИнформация о pet3:");
        pet3.PrintInfo();

        // Используем конструктор со всеми параметрами.
        Pet pet4 = new Pet("Кеша", "Попугай", 1, 0.1, false);
        Console.WriteLine("\nИнформация о pet4:");
        pet4.PrintInfo();

        // Используем методы класса

        pet2.SetWeight(4.0); // Изменение веса
        pet4.SetHealth(true); // Изменение состояния здоровья

        Console.WriteLine("\nОбновленная информация о pet2:");
        pet2.PrintInfo();

        Console.WriteLine("\nОбновленная информация о pet4:");
        pet4.PrintInfo();
    }
}
