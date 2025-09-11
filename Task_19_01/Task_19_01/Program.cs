using System;
public class StringReplacer
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Введите подстроку для поиска:");
        string searchString = Console.ReadLine();

        Console.WriteLine("Введите подстроку для замены:");
        string replaceString = Console.ReadLine();

        string resultString = inputString.Replace(searchString, replaceString);

        Console.WriteLine("Результат: " + resultString);
    }
}