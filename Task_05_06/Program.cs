using System;

public class MatrixGenerationAndTranspose
{
    public static void Main(string[] args)
    {
        int rows = 10;
        int cols = 5;

        int[,] matrix = GenerateMatrix(rows, cols);

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] transposedMatrix = TransposeMatrix(matrix);

        Console.WriteLine("\nТранспонированная матрица:");
        PrintMatrix(transposedMatrix);

        Console.ReadKey();
    }

    static int[,] GenerateMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int num;
                switch (j)
                {
                    case 0: num = 0; break;
                    case 1: num = random.Next(1, 50) * 2; break;
                    case 2: num = random.Next(1, 34) * 3; break;
                    case 3: num = random.Next(1, 26) * 4; break;
                    case 4: num = random.Next(1, 21) * 5; break;
                    default: num = 0; break;
                }
                matrix[i, j] = num;
            }
        }
        return matrix;
    }

    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],4} ");
            }
            Console.WriteLine();
        }
    }
}


