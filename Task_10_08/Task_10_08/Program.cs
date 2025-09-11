using System;

public class SearchElement
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 10, 15, 20, 25, 30 };

        Console.WriteLine("Введите число для поиска:");
        int numberToSearch = int.Parse(Console.ReadLine());

        int index = FindElementIndex(array, numberToSearch);

        if (index != -1)
        {
            Console.WriteLine($"Индекс элемента {numberToSearch} в массиве: {index}");
        }
        else
        {
            Console.WriteLine($"Элемент {numberToSearch} не найден в массиве.");
        }
    }

    public static int FindElementIndex(int[] array, int numberToSearch)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == numberToSearch)
            {
                return i; // элемент найден, возвращаем его индекс
            }
        }

        return -1; // элемент не найден, возвращаем -1
    }
}