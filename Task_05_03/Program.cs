using System;

public class CompareMatrices
{
    public static void Main(string[] args)
    {
        char[,] matrix1 = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'},
            {'g', 'h', 'i'}
        };

        char[,] matrix2 = {
            {'a', 'b', 'c'},
            {'d', 'x', 'f'},
            {'g', 'h', 'i'}
        };


        bool areEqual = AreMatricesEqual(matrix1, matrix2);

        if (areEqual)
        {
            Console.WriteLine("Матрицы равны.");
        }
        else
        {
            Console.WriteLine("Матрицы не равны.");
            PrintMatricesWithColoredEquals(matrix1, matrix2);
        }

        Console.ReadKey();
    }

    static bool AreMatricesEqual(char[,] matrix1, char[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            return false;
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                if (matrix1[i, j] != matrix2[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void PrintMatricesWithColoredEquals(char[,] matrix1, char[,] matrix2)
    {
        Console.WriteLine("\nМатрица 1:");
        PrintMatrix(matrix1, matrix2);

        Console.WriteLine("\nМатрица 2:");
        PrintMatrix(matrix2, matrix1);
    }

    static void PrintMatrix(char[,] matrix, char[,] otherMatrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == otherMatrix[i, j])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
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

