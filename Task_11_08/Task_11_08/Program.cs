using System;

public class SumAndMax
{
    public static void Main(string[] args)
    {
        int sum;
        int max;

        CalculateSumAndMax(out sum, out max, 1, 2, 3, 4, 5);
        Console.WriteLine($"Сумма: {sum}, Максимум: {max}");

        CalculateSumAndMax(out sum, out max, 10, 5, 20);
        Console.WriteLine($"Сумма: {sum}, Максимум: {max}");

        CalculateSumAndMax(out sum, out max); // Вызов без аргументов
        Console.WriteLine($"Сумма: {sum}, Максимум: {max}");
    }

    public static void CalculateSumAndMax(out int sum, out int max, params int[] numbers)
    {
        sum = 0;
        max = int.MinValue; // Инициализируем max наименьшим возможным значением int

        if (numbers == null || numbers.Length == 0)
        {
            Console.WriteLine("Предупреждение: передан пустой массив. Сумма = 0, Максимум = Int32.MinValue");
            return; // Завершаем метод, если массив пустой
        }

        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
        }
    }
}