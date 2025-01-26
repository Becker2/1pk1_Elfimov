using System;
using System.Linq;

public class StudentHeights
{
    public static void Main(string[] args)
    {
        int[] heights = GenerateHeightsArray();

        int boysCount = heights.Count(h => h < 0);
        int girlsCount = heights.Count(h => h >= 0);

        double avgBoysHeight = heights.Where(h => h < 0).Select(Math.Abs).Average();
        double avgGirlsHeight = heights.Where(h => h >= 0).Average();

        Console.WriteLine($"Количество мальчиков: {boysCount}");
        Console.WriteLine($"Количество девочек: {girlsCount}");
        Console.WriteLine($"Средний рост мальчиков: {avgBoysHeight:F2} см");
        Console.WriteLine($"Средний рост девочек: {avgGirlsHeight:F2} см");

        Console.ReadKey();
    }

    static int[] GenerateHeightsArray()
    {
        Random random = new Random();
        int[] heights = new int[30];
        for (int i = 0; i < 30; i++)
        {
            int height = random.Next(140, 191);
            if (random.NextDouble() < 0.5) height *= -1;
            heights[i] = height;
        }
        return heights;
    }
}

