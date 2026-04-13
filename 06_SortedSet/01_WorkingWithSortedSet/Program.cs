using System;
using System.Collections.Generic;

static class WorkingWithSortedSet
{
    static void Main(string[] args)
    {
        // Initialize set
        SortedSet<int> set =new SortedSet<int>();

        // Add elements to the set
        set.Add(6);
        set.Add(8);
        set.Add(10);
        set.Add(1);
        set.Add(-1);
        set.Add(99);

        // Print the set
        Console.WriteLine("Set numbers:");
        foreach (int num in set)
        {
            Console.WriteLine(num);
        }


        // Remove elements
        set.Remove(8);

        Console.WriteLine("\nSet after removing number '8' is:");
        foreach (int num in set)
        {
            Console.WriteLine(num);
        }


        // Check contains
        Console.WriteLine("\nDoes set contains number '2': " + set.Contains(2));
        Console.WriteLine("Does set contains number -1: " + set.Contains(-1));
    }
}
