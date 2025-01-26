using System;

public class ZMatrixChecker
{
    public static void Main(string[] args)
    {
        Console.Write("Введите размерность квадратной матрицы (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
            return;
        }

        int[,] matrix = GenerateRandomMatrix(n);

        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);

        if (IsZMatrix(matrix))
        {
            Console.WriteLine("\nМатрица является Z-матрицей. Вывод с цветовой индикацией главной диагонали:");
            PrintMatrixWithDiagonalHighlight(matrix);
        }
        else
        {
            Console.WriteLine("\nМатрица не является Z-матрицей.");
        }
    }

    static int[,] GenerateRandomMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    matrix[i, j] = random.Next(-10, 20);
                }
                else
                {
                    matrix[i, j] = random.Next(-10, 0);
                }
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static bool IsZMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != j && matrix[i, j] >= 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void PrintMatrixWithDiagonalHighlight(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(matrix[i, j] + "\t");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}