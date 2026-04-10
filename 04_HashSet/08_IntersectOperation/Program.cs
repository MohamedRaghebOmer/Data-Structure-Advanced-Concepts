using System;
using System.Collections.Generic;
using System.Linq;

static class IntersectOperation
{
    static void Main(string[] args)
    {
        HashSet<int> numbers1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> numbers2 = new HashSet<int>() { 3, 4, 5, 6, 7 };

        // Print 'numbers1' and 'numbers2'
        Console.WriteLine("numbers1: " + string.Join(", ", numbers1));
        Console.WriteLine("numbers2: " + string.Join(", ", numbers2));

        // Print the intersection with modifying 'numbers1' to be the intersection between both sets
        numbers1.IntersectWith(numbers2);
        Console.WriteLine("\nIntersection from 'numbers1': " + string.Join(", ", numbers1));

        // Print the intersection from a new collection
        Console.WriteLine("Intersection from new collection: " + string.Join(", ", numbers1.Intersect(numbers2)));
    }
}
