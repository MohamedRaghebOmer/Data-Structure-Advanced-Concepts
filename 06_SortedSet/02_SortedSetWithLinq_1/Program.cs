using System;
using System.Collections.Generic;
using System.Linq;

static class SortedSetWithLinq_1
{
    static void Main(string[] args)
    {
        SortedSet<int> sortedSet = new SortedSet<int>() { 1, 2, 3, 4, 5 };

        // Print all set elements
        Console.WriteLine("All elements:");
        foreach (int num in sortedSet)
        {
            Console.WriteLine(num);
        }

        // Filtering elements greater than 2
        var filteredSet = sortedSet.Where(x => x > 2);
        Console.WriteLine("Numbers greater than 2:");
        foreach (var item in filteredSet)
        {
            Console.Write(item + " ");
        }

        // Sum of all elements
        var sum = sortedSet.Sum();
        Console.WriteLine("\nSum of all elements: " + sum);


        // Maximum and minimum elements
        var maxElement = sortedSet.Max();
        var minElement = sortedSet.Min();
        Console.WriteLine("\nMaximum element: " + maxElement);
        Console.WriteLine("Minimum element: " + minElement);


        // Sorting the set in descending order
        var descendingSet = sortedSet.OrderByDescending(x => x);
        Console.WriteLine("\nDescending Sorted Set:");
        foreach (var item in descendingSet)
        {
            Console.Write(item + " ");
        }
    }
}