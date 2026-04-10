using System;
using System.Collections.Generic;

static class SymmetricDifferenceOperation
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

        // Print both sets
        Console.WriteLine("Set1: " + string.Join(", ", set1));
        Console.WriteLine("Set2: " + string.Join(" ,", set2));

        // 'SymmetricExcept' Keeps only elements that exist in one collection but NOT both.
        // In another words: It removes the common elements between two sets
        set1.SymmetricExceptWith(set2);

        Console.WriteLine("Numbers after removing the common numbers: " + string.Join(", ", set1));

        // The difference between 'SymmetricExceptWith' and 'UnionWith' that is 'Union' remove the duplication and
        // keeps one non-repeated elements instead of removing repeated elements at all
    }
}