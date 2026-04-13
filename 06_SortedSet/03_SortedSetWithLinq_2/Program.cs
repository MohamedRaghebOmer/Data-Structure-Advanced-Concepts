using System;
using System.Collections.Generic;
using System.Linq;

static class SortedSetWithLinq_2
{
    static void Main(string[] args)
    {
        SortedSet<int> numbers = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Find even numbers and project them to their square
        var evenNumbersSquared = numbers.Where(x => x % 2 == 0).Select(x => x * x);
        Console.WriteLine("Squares of even numbers:");
        foreach (var item in evenNumbersSquared)
        {
            Console.Write(item + " "); // 4 16 36 64 100
        }
    }
}