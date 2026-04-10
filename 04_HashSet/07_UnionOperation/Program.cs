using System;
using System.Collections.Generic;
using System.Linq;

static class UnionOperation
{
    static void Main(string[] args)
    {
        // Declare 2 hash sets. number '3' is repeated in both sets
        HashSet<int> numbers1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> numbers2 = new HashSet<int>() { 3, 4, 5 };

        // Print the each set
        Console.WriteLine("Set1: " + string.Join(", ", numbers1));
        Console.WriteLine("Set2: " + string.Join(", ", numbers2));

        // Merge/Union both sets in one set including remove duplicate data in both sets
        // Combine the both sets elements and modifies 'numbers1' set with non-duplicated data.
        numbers1.UnionWith(numbers2);

        // Print the result
        Console.WriteLine("\nSet1 after union with Set2: " + string.Join(", ", numbers1));
        
        // The same idea of 'UnionWith' but does NOT modifies 'numbers1' elements but return the result.
        var nonDuplicated = numbers1.Union(numbers2);

        Console.WriteLine("\nElements from new collection: " + string.Join(", ", nonDuplicated));
    }
}
