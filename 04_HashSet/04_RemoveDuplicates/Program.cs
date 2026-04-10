using System;
using System.Collections.Generic;
using System.Linq;

static class RemoveDuplicates
{
    static void Main(string[] args)
    {
        // Initialize array with duplicate data
        int[] duplicateNumbers = new int[] { 1, 2, 3, 3, 3, 4, 5, 6, 7, 7, 7};

        Console.WriteLine("Duplicate numbers from the array:");
        foreach (int num in duplicateNumbers)
        {
            Console.WriteLine(num);
        }

        // Initialize a hash set, will automatically remove the duplicate numbers from the array.
        HashSet<int> hashSet = new HashSet<int>(duplicateNumbers);

        Console.WriteLine("\nNumbers from hash set after removing duplicate numbers:");
        foreach (int num in hashSet)
        {
            Console.WriteLine(num);
        }

        // Turn the hash set into array again
        int[] array = hashSet.ToArray();

        Console.WriteLine("\nPrinting numbers after putting back in an array:");
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }
}
