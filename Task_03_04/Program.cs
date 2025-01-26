using System;

class Program
{
    static void Main()
    {
        int lineCount = 0; 
        string input;

        while (true)
        {
            Console.Clear(); 
            Console.WriteLine("Введите произвольный текст (введите 'exit' или оставьте строку пустой для выхода):");
            input = Console.ReadLine();

            
            if (input == "exit" || string.IsNullOrWhiteSpace(input))
            {
                break; 
            }

            lineCount++; 
        }

        
        Console.Clear(); 
        Console.WriteLine($"Количество введенных строк: {lineCount}");
    }
}

