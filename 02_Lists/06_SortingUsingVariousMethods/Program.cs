using System;
using System.Collections.Generic;
using System.Linq;

static class SortingUsingVariousMethods
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { -20, 0, 666, -1, 20, 999, -90, 60 };

        // Print the main list before operating any sorting.
        Console.WriteLine("List before sorting is: " + string.Join(", ", numbers));

        // Sort the list ASC
        numbers.Sort();
        Console.WriteLine("List after sorting ascending is: " + string.Join(", ", numbers));

        // Reverse the list. Reversing the list after sorting ASC means that is the list will be sorted DESC.
        numbers.Reverse();
        Console.WriteLine("List after reversing is: " + string.Join(", ", numbers));


        //--------------Using LINQ--------------

        // Sort the list ASC
        Console.WriteLine("List after sorting ASC with LINQ: " + string.Join(", ", numbers.OrderBy(n => n)));

        // Sort the list DESC
        Console.WriteLine("List after sorting DESC with LINQ: " + string.Join(", ", numbers.OrderByDescending(n => n)));

        // Shuffle the list
        Console.WriteLine("List after shuffling: " + string.Join(", ", numbers.OrderBy(n => Guid.NewGuid())));
    }
}
