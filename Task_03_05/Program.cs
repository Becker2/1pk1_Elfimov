using System;

public class TemperatureConverter
{
    public static void Main(string[] args)
    {

        Console.Write("Введите начальную температуру в градусах Цельсия: ");
        if (!double.TryParse(Console.ReadLine(), out double startCelsius))
        {
            Console.WriteLine("Некорректный ввод начальной температуры.");
            return;
        }

        Console.Write("Введите конечную температуру в градусах Цельсия: ");
        if (!double.TryParse(Console.ReadLine(), out double endCelsius))
        {
            Console.WriteLine("Некорректный ввод конечной температуры.");
            return;
        }

        Console.Write("Введите шаг изменения температуры в градусах Цельсия: ");
        if (!double.TryParse(Console.ReadLine(), out double step))
        {
            Console.WriteLine("Некорректный ввод шага.");
            return;
        }

        if (step == 0)
        {
            Console.WriteLine("Шаг не может быть равен нулю.");
            return;
        }

        if (startCelsius > endCelsius && step > 0 || startCelsius < endCelsius && step < 0)
        {
            Console.WriteLine("Некорректный диапазон или шаг.");
            return;
        }

        Console.WriteLine("\nЦельсий\tФаренгейт");
        Console.WriteLine("---------------------");


        for (double celsius = startCelsius;
             startCelsius < endCelsius ? celsius <= endCelsius : celsius >= endCelsius;
             celsius += step)
        {
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius:F2}\t\t{fahrenheit:F2}");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 1.8 + 32;
    }
}
