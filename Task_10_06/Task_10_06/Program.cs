using System;

public class ArrayGenerator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива:");
        int n = int.Parse(Console.ReadLine());

        ArrayGeneration(n);
    }
    public static void ArrayGeneration(int n)
    {
        Random random = new Random();
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(100); // генерируем случайное число от 0 до 99
        }

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine(); // переход на новую строку после вывода массива
    }
}