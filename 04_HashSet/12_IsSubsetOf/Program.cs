using System;
using System.Collections.Generic;

static class IsSubsetOf
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2 };
        HashSet<int> set2 = new HashSet<int>() { 1, 2, 3, 4, 5 };

        // Print the sets
        Console.WriteLine("Set1: " + string.Join(", ", set1));
        Console.WriteLine("Set2: " + string.Join(", ", set2));

        // Check subset
        Console.WriteLine("\nIs Set1 subset of Set2: " + set1.IsSubsetOf(set2));
        Console.WriteLine("Is Set2 subset of Set1: " + set2.IsSubsetOf(set1));
    }
}
