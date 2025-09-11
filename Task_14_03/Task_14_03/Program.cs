using System;

public class FactorialCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите неотрицательное целое число:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            try
            {
                long factorial = Factorial(number);
                Console.WriteLine($"Факториал числа {number} равен {factorial}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введите целое число.");
        }
    }

    // Статический метод для вычисления факториала.
    public static long Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
        }

        if (n == 0)
        {
            return 1; // Факториал 0 равен 1
        }

        if (n > 20)
        {
            throw new ArgumentException("Внимание: факториал этого числа вызовет переполнение типа long.");
        }

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}
