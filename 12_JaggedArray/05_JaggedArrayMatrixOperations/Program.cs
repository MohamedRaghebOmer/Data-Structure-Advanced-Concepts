/*
Jagged Array Matrix Operations: Performing matrix operations using jagged arrays
This project demonstrates arithmetic operations on matrices stored in jagged arrays.
*/

using System;

static class JaggedArrayMatrixOperations
{
    static void Main(string[] args)
    {
        // Create two 3x3 matrices (with jagged structure)
        int[][] matrixA = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };

        int[][] matrixB = new int[][]
        {
            new int[] { 9, 8, 7 },
            new int[] { 6, 5, 4 },
            new int[] { 3, 2, 1 }
        };

        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        // Matrix addition
        int[][] sum = AddMatrices(matrixA, matrixB);
        Console.WriteLine("\nMatrix A + B:");
        PrintMatrix(sum);

        // Scalar multiplication
        int[][] scaled = ScalarMultiply(matrixA, 2);
        Console.WriteLine("\nMatrix A × 2:");
        PrintMatrix(scaled);

        // Transpose matrix
        int[][] transposed = TransposeMatrix(matrixA);
        Console.WriteLine("\nTranspose of Matrix A:");
        PrintMatrix(transposed);

        // Calculate matrix trace (sum of diagonal elements)
        int trace = CalculateTrace(matrixA);
        Console.WriteLine($"\nTrace of Matrix A: {trace}");
    }

    static int[][] AddMatrices(int[][] a, int[][] b)
    {
        int rows = a.Length;
        int[][] result = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            int cols = a[i].Length;
            result[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                result[i][j] = a[i][j] + b[i][j];
            }
        }
        return result;
    }

    static int[][] ScalarMultiply(int[][] matrix, int scalar)
    {
        int rows = matrix.Length;
        int[][] result = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            int cols = matrix[i].Length;
            result[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                result[i][j] = matrix[i][j] * scalar;
            }
        }
        return result;
    }

    static int[][] TransposeMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[][] result = new int[cols][];

        for (int j = 0; j < cols; j++)
        {
            result[j] = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                result[j][i] = matrix[i][j];
            }
        }
        return result;
    }

    static int CalculateTrace(int[][] matrix)
    {
        int trace = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            trace += matrix[i][i];
        }
        return trace;
    }

    static void PrintMatrix(int[][] matrix)
    {
        foreach (int[] row in matrix)
        {
            foreach (int val in row)
            {
                Console.Write($"{val,4}");
            }
            Console.WriteLine();
        }
    }
}
