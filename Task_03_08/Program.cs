using System;

public class Numbers
{
    public static void Main(string[] args)
    {
        int startNumber = 20;
        int endNumber = 50;

        Console.WriteLine("Числа от 20 до 50, которые делятся на 3, но не делятся на 5:");

        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("\nНажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}

