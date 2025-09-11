using System;

public class StringAnalyzer
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        int vowelCount;
        int consonantCount;

        AnalyzeString(inputString, out vowelCount, out consonantCount); // Использование out

        Console.WriteLine($"Количество гласных: {vowelCount}");
        Console.WriteLine($"Количество согласных: {consonantCount}");
    }

    // Метод для анализа строки и подсчета гласных и согласных букв.
    // Использует выходные параметры (out) для возврата результатов.
    public static void AnalyzeString(string str, out int vowels, out int consonants) // Параметры out
    {
        vowels = 0;
        consonants = 0;

        str = str.ToLower(); // Преобразование строки к нижнему регистру для упрощения анализа

        foreach (char c in str)
        {
            if (char.IsLetter(c)) // Проверяем, является ли символ буквой
            {
                if (c == 'а' || c == 'е' || c == 'ё' || c == 'и' || c == 'о' || c == 'у' || c == 'ы' || c == 'э' || c == 'ю' || c == 'я')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
        }
    }
}