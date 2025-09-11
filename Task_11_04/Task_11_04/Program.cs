using System;

public class AverageCalculator
{
    public static void Main(string[] args)
    {
        double average1 = CalculateAverage(1, 2, 3, 4, 5);
        Console.WriteLine($"Среднее значение (1, 2, 3, 4, 5): {average1}");

        double average2 = CalculateAverage(10, 20, 30);
        Console.WriteLine($"Среднее значение (10, 20, 30): {average2}");

        double average3 = CalculateAverage(); // Вызов без аргументов
        Console.WriteLine($"Среднее значение (пустой массив): {average3}"); // Вывод NaN (Not a Number)

        double average4 = CalculateAverage(new double[] { 1.5, 2.5, 3.5 }); // Передача массива
        Console.WriteLine($"Среднее значение (массив 1.5, 2.5, 3.5): {average4}");
    }


    public static double CalculateAverage(params double[] numbers) // Использование params
    {
        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Предупреждение: передан пустой массив. Возвращается NaN.");
            return double.NaN; // Возвращаем NaN (Not a Number), если массив пустой
        }

        double sum = 0;
        foreach (double number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }
}