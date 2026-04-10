using System;
using System.Collections.Generic;
using System.Linq;

static class DifferenceOperation
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };

        // Print 'set1' and 'set2'
        Console.WriteLine("Set1: " + string.Join(", ", set1));
        Console.WriteLine("Set2: " + string.Join(", ", set2));

        // Get the elements that in 'set2' but NOT in 'set1' in new collection
        var diff = set1.Except(set2);
        Console.WriteLine("\nNumbers in 'Set1' but not in 'Set2' from new collection: " + string.Join(", ", diff));

        // Modify 'set1' to hold the elements that exists in 'set2' and does not exist in it self
        set1.ExceptWith(set2);
        Console.WriteLine("Set1 after modifying to hold the difference: " + string.Join(", ", set1));
    }
}
