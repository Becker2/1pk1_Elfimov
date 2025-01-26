using System;

public class RainfallStatistics
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] rainfall = new int[30];

        for (int i = 0; i < 30; i++)
        {
            rainfall[i] = random.Next(0, 301);
        }

        int decada1Rainfall = 0;
        int decada2Rainfall = 0;
        int decada3Rainfall = 0;

        for (int i = 0; i < 10; i++) decada1Rainfall += rainfall[i];
        for (int i = 10; i < 20; i++) decada2Rainfall += rainfall[i];
        for (int i = 20; i < 30; i++) decada3Rainfall += rainfall[i];

        int maxRainfallDay = 0;
        int maxRainfall = 0;

        for (int i = 0; i < 30; i++)
        {
            if (rainfall[i] > maxRainfall)
            {
                maxRainfall = rainfall[i];
                maxRainfallDay = i + 1;
            }
        }

        Console.Write("Дни без осадков: ");
        bool firstDay = true;
        for (int i = 0; i < 30; i++)
        {
            if (rainfall[i] == 0)
            {
                if (!firstDay) Console.Write(", ");
                Console.Write(i + 1);
                firstDay = false;
            }
        }
        Console.WriteLine();


        Console.WriteLine("\nКоличество осадков за декады:");
        Console.WriteLine($"Первая декада: {decada1Rainfall} мм");
        Console.WriteLine($"Вторая декада: {decada2Rainfall} мм");
        Console.WriteLine($"Третья декада: {decada3Rainfall} мм");
        Console.WriteLine($"\nДень с самыми сильными осадками: {maxRainfallDay} ({maxRainfall} мм)");

        Console.ReadKey();
    }
}

