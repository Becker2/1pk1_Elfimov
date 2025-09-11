using System;
using System.Collections.Generic;
using System.Linq;

public class StringCombiner
{
    public static void Main(string[] args)
    {
        List<string> inputLines = new List<string>();
        string line;
        int lineNumber = 1;

        Console.WriteLine("Введите строки (для завершения введите пустую строку):");

        do
        {
            Console.Write($"Введите строку {lineNumber}: ");
            line = Console.ReadLine();

            if (!string.IsNullOrEmpty(line))
            {
                inputLines.Add(line);
                lineNumber++;
            }

        } while (!string.IsNullOrEmpty(line));

        string resultString = string.Join("-", inputLines);

        Console.WriteLine($"Результат: {resultString}");
    }
}
