using System;

public class MatrixOperations
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

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int minElement = FindMinElement(matrix);
        Console.WriteLine($"Минимальный элемент в матрице: {minElement}");

        MultiplyMatrixByScalar(matrix, minElement);
        Console.WriteLine("nМатрица, умноженная на минимальный элемент:");
        PrintMatrixWithHighlightedMax(matrix);
    }

    static int[,] GenerateRandomMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(10, 100);
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
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int FindMinElement(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int min = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }
        return min;
    }

    static void MultiplyMatrixByScalar(int[,] matrix, int scalar)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] *= scalar;
            }
        }
    }

    static void PrintMatrixWithHighlightedMax(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int[] flatMatrix = new int[n * n];
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                flatMatrix[k++] = matrix[i, j];
            }
        }

        Array.Sort(flatMatrix);
        Array.Reverse(flatMatrix);

        int[] maxValues = new int[Math.Min(5, flatMatrix.Length)];
        Array.Copy(flatMatrix, maxValues, maxValues.Length);


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                bool isMax = false;
                for (int m = 0; m < maxValues.Length; m++)
                {
                    if (matrix[i, j] == maxValues[m])
                    {
                        isMax = true;
                        break;
                    }
                }

                if (isMax)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(matrix[i, j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}
