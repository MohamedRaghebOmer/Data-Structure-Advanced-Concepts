using System;
using System.Collections.Generic;
using System.Linq;

static class LinqWithSortedList
{
    static void Main(string[] args)
    {
        SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "One" },
            { 2, "Two" },
            { 5, "Five" },
            { 4, "Four" },
            { 3, "Three" },
        };

        // Print the sorted list
        Console.WriteLine("List: " + string.Join(", ", sortedList));


        //--------------Querying using expression syntax--------------

        Console.WriteLine("\nFiltering using expression syntax");

        // Filter key greater than 2
        var keyGreaterThan5_expression = from kvp in sortedList where kvp.Key > 2 select kvp;
        Console.WriteLine("\nKey greater than 5: " + string.Join(", ", keyGreaterThan5_expression));

        // Filter value starts with 'F'
        var valueStartsWith_F_expression = from kpv in sortedList where kpv.Value.StartsWith("F") select kpv;
        Console.WriteLine("Value starts with 'F': " + string.Join(", ", valueStartsWith_F_expression));

        // Filter value length is 3
        var valueLengthIs3_expression = from kpv in sortedList where kpv.Value.Length == 3 select kpv;
        Console.WriteLine("Value length is 3: " + string.Join(", ", valueLengthIs3_expression));

        // Filter value contains 'e'
        var valueContains_e_expression = from kpv in sortedList where kpv.Value.Contains("e") select kpv;
        Console.WriteLine("Value word contains letter 'e': " + string.Join(", ", valueContains_e_expression));




        //--------------Querying using method syntax--------------

        Console.WriteLine("\nFiltering using method syntax");

        var keyGreaterThan5_method = sortedList.Where(kvp => kvp.Key > 5);
        Console.WriteLine("\nKey greater than 5: " + string.Join(", ", keyGreaterThan5_expression));

        // Filter value starts with 'F'
        var valueStartsWith_F_method = sortedList.Where(kvp => kvp.Value.StartsWith("F"));
        Console.WriteLine("Value starts with 'F': " + string.Join(", ", valueStartsWith_F_expression));

        // Filter value length is 3
        var valueLengthIs3_method = sortedList.Where(kvp => kvp.Value.Length == 3);
        Console.WriteLine("Value length is 3: " + string.Join(", ", valueLengthIs3_expression));

        // Filter value contains 'e'
        var valueContains_e_method = sortedList.Where(kvp => kvp.Value.Contains("e"));
        Console.WriteLine("Value word contains letter 'e': " + string.Join(", ", valueContains_e_expression));


        Console.ReadLine();
    }
}
