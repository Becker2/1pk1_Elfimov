using System;
using System.Collections.Generic;
using System.Linq;
public class EvenNumbersMultiplier
{
    public static void Main(string[] args)
    {
        // Исходный список чисел
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Создаём новый список, содержащий только чётные числа, умноженные на 10
        List<int> evenNumbersMultiplied = numbers
            .Where(number => number % 2 == 0) // Фильтруем, оставляя только чётные числа
            .Select(number => number * 10)   // Умножаем каждое чётное число на 10
            .ToList();                         // Преобразуем результат обратно в список

        // Выводим новый список
        Console.WriteLine("Исходный список: " + string.Join(", ", numbers));
        Console.WriteLine("Чётные числа, умноженные на 10: " + string.Join(", ", evenNumbersMultiplied));
    }
}