using System;

public class Matrix
{
    public static void Main(string[] args)
    {
        Console.Write("Введите количество строк (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некорректное количество строк.");
            return;
        }

        Console.Write("Введите количество столбцов (m): ");
        if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
        {
            Console.WriteLine("Некорректное количество столбцов.");
            return;
        }

        int[,] matrix = GenerateRandomMatrix(n, m);

        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);

        MatrixInPlace(matrix);

        Console.WriteLine("\nПреобразованная матрица:");
        PrintMatrixWithColor(matrix);

        Console.ReadKey();
    }

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(-99, 100);
            }
        }
        return matrix;
    }

    static void MatrixInPlace(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < 0)
                {
                    matrix[i, j] = Math.Abs(matrix[i, j]);
                }
                else if (matrix[i, j] == 0)
                {
                    matrix[i, j] = 1;
                }
            }
        }
    }


    static void PrintMatrixWithColor(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (matrix[i, j] > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write($"{matrix[i, j],3} ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
    }
}