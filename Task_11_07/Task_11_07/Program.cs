using System;

public class ArrayManipulationRef
{
    public static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        IncreaseArrayElementsRef(ref originalArray); // Передача по ссылке (ref)

        Console.WriteLine("\nМассив после вызова метода:");
        PrintArray(originalArray);
    }

    // Метод для увеличения каждого элемента массива на 1 (передача массива по ссылке - ref).
    public static void IncreaseArrayElementsRef(ref int[] array) // Использование ref
    {
        Console.WriteLine("  Внутри метода:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i]++; // Увеличение элемента массива
            Console.Write($" {array[i]}");
        }
        Console.WriteLine();

    }

    // Метод для вывода массива на консоль.
    public static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}