using System;
using System.Collections;
    
static class WorkingWithJaggedArray
{
    static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] { 0, 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5, 6, 7, 8, 9, 10 ,11};
        jaggedArray[2] = new int[] { 12 };

        // Display elements
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
    