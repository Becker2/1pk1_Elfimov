using System;
using System.IO;
public class FileLineCounter
{
    public static int CountLines(string filePath)
    {
        int lineCount = 0;

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл не найден: {filePath}");
            return -1; // Или выбросить исключение, в зависимости от требований
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            return -1; // Или выбросить исключение
        }

        return lineCount;
    }

    public static void Main(string[] args)
    {
        string filePath = "example.txt"; // Замените на путь к вашему файлу

        // Создаем файл example.txt с несколькими строками
        try
        {
            File.WriteAllLines(filePath, new string[] { "Строка 1", "Строка 2", "Строка 3", "Строка 4" });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
            return;
        }

        int lineCount = CountLines(filePath);

        if (lineCount != -1)
        {
            Console.WriteLine($"Количество строк в файле {filePath}: {lineCount}");
        }
    }
}