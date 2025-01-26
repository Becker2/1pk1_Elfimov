using System;

public class ReverseArrayHalves
{
    public static void Main(string[] args)
    {
        int[] array = GenerateRandomArray(10);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ReverseFirstHalf(array);
        Console.WriteLine("\nМассив после реверса первой половины:");
        PrintArray(array);

        ReverseSecondHalf(array);
        Console.WriteLine("\nМассив после реверса второй половины:");
        PrintArray(array);

        Console.ReadKey();
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(-10, 11);
        }
        return arr;
    }

    static void ReverseFirstHalf(int[] arr)
    {
        int mid = arr.Length / 2;
        for (int i = 0; i < mid / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[mid - 1 - i];
            arr[mid - 1 - i] = temp;
        }
    }

    static void ReverseSecondHalf(int[] arr)
    {
        int mid = arr.Length / 2;
        for (int i = mid; i < mid + (arr.Length - mid) / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - (i - mid)];
            arr[arr.Length - 1 - (i - mid)] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}

