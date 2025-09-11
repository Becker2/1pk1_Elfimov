using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class WordSearch
{
    public static List<string> FindLinesContainingWord(string filePath, string word)
    {
        List<string> matchingLines = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Приводим обе строки к нижнему регистру для регистронезависимого поиска
                    if (line.ToLower().Contains(word.ToLower()))
                    {
                        matchingLines.Add(line);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл не найден: {filePath}");
            return null; // Или выбросить исключение
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return null; // Или выбросить исключение
        }

        return matchingLines;
    }

    public static void Main(string[] args)
    {
        string filePath = "example.txt";
        string searchWord = "строка";
        // Создаем файл example.txt с несколькими строками
        try
        {
            File.WriteAllLines(filePath, new string[] { "Это Строка 1", "Еще одна строка", "Строка 3 содержит искомое слово", "А тут строки нет" });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
            return;
        }


        List<string> matchingLines = FindLinesContainingWord(filePath, searchWord);

        if (matchingLines != null)
        {
            Console.WriteLine($"Строки, содержащие слово \"{searchWord}\" (регистронезависимо):");
            if (matchingLines.Count == 0)
            {
                Console.WriteLine("Слово не найдено.");
            }
            else
            {
                foreach (string line in matchingLines)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}