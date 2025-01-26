using System;

public class DiagonalMatrix
{
    public static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 0, 0},
            {0, 2, 0},
            {0, 0, 3}
        };

        int n = matrix.GetLength(0);

        if (IsDiagonal(matrix, n))
        {
            Console.WriteLine("Матрица является диагональной.");
            PrintMatrixWithHighlight(matrix, n);
        }
        else
        {
            Console.WriteLine("Матрица не является диагональной.");
        }

        Console.ReadKey();
    }

    static bool IsDiagonal(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i != j && matrix[i, j] != 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void PrintMatrixWithHighlight(int[,] matrix, int n)
    {
        Console.WriteLine("\nМатрица с выделенной главной диагональю:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(matrix[i, j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}


