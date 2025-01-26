using System;
using System.Collections.Generic;
using System.Linq;

public class Numbers
{
    public static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int arraySize) || arraySize <= 0)
        {
            Console.WriteLine("Некорректный размер массива.");
            return;
        }

        int[] array = GenerateArrayWithNumbers(arraySize);

        if (array == null)
        {
            Console.WriteLine("Не удалось создать массив с заданными условиями.");
            return;
        }

        Console.WriteLine("Полученный массив:");
        PrintArray(array);

        int maxAbsValue = FindMaxAbsoluteValue(array);
        Console.WriteLine($"\nНаибольшее по модулю число: {maxAbsValue}");

        Console.ReadKey();
    }

    static int[] GenerateArrayWithNumbers(int size)
    {
        Random random = new Random();
        HashSet<int> absoluteValues = new HashSet<int>();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            int absValue;
            do
            {
                absValue = random.Next(1, size * 2 + 1);
            } while (absoluteValues.Contains(absValue));

            absoluteValues.Add(absValue);
            array[i] = random.NextDouble() < 0.5 ? -absValue : absValue;
        }

        return array;
    }

    static int FindMaxAbsoluteValue(int[] arr)
    {
        return arr.Max(Math.Abs);
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}

