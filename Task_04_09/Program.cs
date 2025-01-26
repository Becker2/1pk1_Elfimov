using System;

public class UniqueElements
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 2, 4, 1, 5, 6, 5, 7, 8, 7, 9, 10, 9 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int[] uniqueElements = FindUniqueElements(array);

        Console.WriteLine("\nУникальные элементы:");
        PrintArray(uniqueElements);

        Console.ReadKey();
    }

    static int[] FindUniqueElements(int[] arr)
    {
        Dictionary<int, int> elementCounts = new Dictionary<int, int>();

        foreach (int element in arr)
        {
            if (elementCounts.ContainsKey(element))
            {
                elementCounts[element]++;
            }
            else
            {
                elementCounts[element] = 1;
            }
        }

        List<int> uniqueList = new List<int>();

        foreach (KeyValuePair<int, int> pair in elementCounts)
        {
            if (pair.Value == 1)
            {
                uniqueList.Add(pair.Key);
            }
        }

        return uniqueList.ToArray();
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}

