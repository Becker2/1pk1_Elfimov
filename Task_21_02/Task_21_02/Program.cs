using System;
using System.Collections.Generic;
using System.Linq;
public class WordCounter
{
    public static Dictionary<string, int> CountWords(string text)
    {
        // 1. Подготовка текста:
        //    - Удаление знаков препинания
        //    - Приведение к нижнему регистру
        string cleanedText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower();

        // 2. Разбиение текста на слова
        string[] words = cleanedText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // 3. Подсчет вхождений каждого слова
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++; // Увеличиваем счётчик, если слово уже есть в словаре
            }
            else
            {
                wordCounts[word] = 1; // Добавляем слово в словарь с начальным счётчиком 1
            }
        }

        return wordCounts;
    }
    public static void Main(string[] args)
    {
        string text = "Это простой текст. Этот текст содержит несколько слов.  Слова могут повторяться, например, это слово это.";

        Dictionary<string, int> wordCounts = CountWords(text);

        Console.WriteLine("Количество вхождений каждого слова:");
        foreach (var pair in wordCounts)
        {
            Console.WriteLine($"\"{pair.Key}\": {pair.Value}");
        }
    }
}