using System;
using System.Collections.Generic;

static class InsertingElements
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

        Console.WriteLine("Initial number:");
        numbers.ForEach(n => Console.WriteLine(n));

        // Insert number '0' at index '0'
        numbers.Insert(0, 0);

        Console.WriteLine("\nNumbers after inserting number 0 at index 0:");
        numbers.ForEach(n => Console.WriteLine(n));

        // Insert number from 6 to 10 at the end of the List
        numbers.InsertRange(6, new List<int>(5) { 6, 7, 8, 9, 10 });

        Console.WriteLine("\nNumbers after inserting numbers from 5 to 10:");
        numbers.ForEach(n => Console.WriteLine(n));
    }
}
