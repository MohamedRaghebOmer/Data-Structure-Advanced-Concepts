using System;


static class CopyArray
{
    static void Main()
    {
        // Original array
        int[] original = { 1, 2, 3, 4, 5 };


        // Array to hold the copy
        int[] copy = new int[original.Length];


        // Copying array
        Array.Copy(original, copy, original.Length);


        // Displaying the copied array
        Console.WriteLine("Copied Array:");
        foreach (int element in copy)
        {
            Console.WriteLine(element);
        }
    }
}