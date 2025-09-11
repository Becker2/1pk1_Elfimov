using System;
using System.IO;
public class TextReplacer
{
    public static bool ReplaceTextInFile(string filePath, string searchText, string replaceText)
    {
        try
        {
            // Читаем все содержимое файла
            string fileContent = File.ReadAllText(filePath);

            // Заменяем текст (регистрозависимо)
            string newContent = fileContent.Replace(searchText, replaceText);

            // Записываем изменения обратно в файл
            File.WriteAllText(filePath, newContent);

            Console.WriteLine($"Текст \"{searchText}\" успешно заменен на \"{replaceText}\" в файле {filePath}");
            return true; // Операция выполнена успешно
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Файл не найден: {filePath}");
            return false; // Файл не найден
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка при чтении или записи файла: {ex.Message}");
            return false; // Ошибка ввода-вывода
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            return false; // Другая ошибка
        }
    }
    public static void Main(string[] args)
    {
        string filePath = "example.txt";

        // Создаем файл example.txt с некоторым содержимым
        try
        {
            File.WriteAllText(filePath, "Это пример текста. В этом тексте нужно что-то заменить.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
            return;
        }

        Console.WriteLine("Введите текст для поиска:");
        string searchText = Console.ReadLine();

        Console.WriteLine("Введите текст для замены:");
        string replaceText = Console.ReadLine();

        bool success = ReplaceTextInFile(filePath, searchText, replaceText);

        if (success)
        {
            Console.WriteLine("Содержимое файла после замены:");
            try
            {
                Console.WriteLine(File.ReadAllText(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла для вывода: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Замена текста не выполнена.");
        }
    }
}