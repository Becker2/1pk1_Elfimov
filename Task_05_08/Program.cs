using System;

public class MatrixMultiplication
{
    public static void Main(string[] args)
    {
        int rows = 10;
        int cols = 10;

        int[,] matrix1 = GenerateRandomMatrix(rows, cols);
        int[,] matrix2 = GenerateRandomMatrix(rows, cols);

        Console.WriteLine("Матрица 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nМатрица 2:");
        PrintMatrix(matrix2);

        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("\nРезультирующая матрица (произведение матриц):");
        PrintMatrix(resultMatrix);
    }

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
            }
        }
        return resultMatrix;
    }
}

