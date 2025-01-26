using System;
using System.Linq;

public class CountEqualPairs
{
    public static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(50);

        Console.WriteLine("Сгенерированный массив:");
        PrintArray(array);

        int equalPairsCount = CountEqualPairsInArray(array);
        Console.WriteLine($"\nКоличество пар равных элементов: {equalPairsCount}");

        Console.ReadKey();
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        return Enumerable.Range(0, size).Select(x => random.Next(-100, 101)).ToArray();
    }

    static int CountEqualPairsInArray(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }
        }
        return count;
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}

