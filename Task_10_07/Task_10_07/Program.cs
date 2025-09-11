using System;

public class CharArrayGenerator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов:");
        int cols = int.Parse(Console.ReadLine());

        char[,] array = GenerateRussianCharArray(rows, cols);
        PrintCharArray(array);
    }

    // метод для генерации двумерного символьного массива
    public static char[,] GenerateRussianCharArray(int rows, int cols)
    {
        char[,] array = new char[rows, cols];
        Random random = new Random();

        // Диапазон символов русского алфавита (от 'а' до 'я')
        int start = (int)'а';
        int end = (int)'я';
        int range = end - start + 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // генерируем случайный индекс для буквы в русском алфавите
                int randomIndex = random.Next(range);
                array[i, j] = (char)(start + randomIndex); // преобразуем индекс обратно в символ
            }
        }

        return array;
    }

    // метод для вывода двумерного символьного массива на консоль.
    public static void PrintCharArray(char[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        Console.WriteLine("Сгенерированный символьный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}