using System;

public class FreeFallVelocityTable
{
    public static void Main(string[] args)
    {
        double g = 9.8;
        double step = 0.5;
        double duration = 10.0;

        Console.WriteLine("Таблица скорости свободно падающего тела");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine(" Время (с) | Скорость (м/с) ");
        Console.WriteLine("---------------------------------------");

        for (double t = 0; t <= duration; t += step)
        {
            double v = g * t;
            Console.WriteLine($"  {t,5:F1}   |   {v,8:F2}  ");
        }

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("\nНажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}

