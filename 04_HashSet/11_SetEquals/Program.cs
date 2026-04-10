using System;
using System.Collections.Generic;

static class SetEquals
{
    static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int>() { 1, 2, 3 };
        HashSet<int> set3 = new HashSet<int>() { 1, 2, 3, 4 };

        // Print sets
        Console.WriteLine("Set1: " + string.Join(", ", set1));
        Console.WriteLine("Set2: " + string.Join(", ", set2));
        Console.WriteLine("Set3: " + string.Join(", ", set3));

        // Check equals
        Console.WriteLine("\nSet1 equals to Set2: " + set1.SetEquals(set2));
        Console.WriteLine("Set2 equals to Set3: " + set2.SetEquals(set3));
    }
}
