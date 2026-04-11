using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

static class Program
{
    static void Main(string[] args)
    {
        // Initialize a SortedList of int keys and string values with fruit names
        SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Grape" },
            { 6, "Fig" },
            { 7, "Elderberry" }
        };


        // Print sorted list elements
        Console.WriteLine("List Elements: " + string.Join(", ", sortedList));


        Console.WriteLine("\n-----------------------------------------------\n");


        // Group items by length and order by length ascending
        var lengthGroups = sortedList.GroupBy(kpv => kpv.Value.Length).OrderBy(kpv => kpv.Key);
        Console.WriteLine("Group by value length:");
        foreach (var group in lengthGroups)
        {
            Console.WriteLine("\nLength[{0}]", group.Key);

            foreach (var item in group)
            {
                Console.WriteLine("- " + item.Value);
            }
        }


        Console.WriteLine("\n-----------------------------------------------\n");


        // Group the sorted list into two groups, (value contains letter 'e' or not).
        var groupByContains_e = sortedList.GroupBy(kpv => kpv.Value.Contains("e"));
        Console.WriteLine("Grouping by contains letter 'e' or not:");
        foreach (var group in groupByContains_e)
        {
            Console.WriteLine("\n" + (group.Key ? "Contains 'e':" : "Does NOT Contains 'e': "));

            foreach (var item in group)
            {
                Console.WriteLine("- " + item.Value);
            }
        }


        Console.WriteLine("\n-----------------------------------------------\n");


        // Group stored list into two groups, (Ends with e or NOT).
        var endsWith_e = sortedList.GroupBy(kpv => kpv.Value.EndsWith("e"));
        Console.WriteLine("Grouping by ends with 'e' or not:");
        foreach (var group in endsWith_e)
        {
            Console.WriteLine("\n" + (group.Key ? "Ends with 'e'" : "Does NOT end with e"));

            foreach (var item in group)
            {
                Console.WriteLine("- " + item.Value);
            }
        }

    }
}