using System;

public class TextAnalyzer
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст, содержащий предложения (со знаками препинания):");
        string inputText = Console.ReadLine();

        Console.WriteLine("\nТекст, разделенный на слова:");
        string[] words = inputText.Split(' ');  // Разделяем по пробелам
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("\nТекст, разделенный на предложения:");
        char[] sentenceDelimiters = { '.', '!', '?' };
        string[] sentences = inputText.Split(sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries); // Разделяем по знакам препинания
        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence.Trim()); // Удаляем лишние пробелы в начале и конце предложения
        }
    }
}