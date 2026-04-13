using System;
using System.Collections.Generic;
using System.Linq;

static class SortedDictionaryWithLinq_1
{
    static void Main()
    {
        SortedDictionary<string, int> stock = new SortedDictionary<string, int>
        {
            { "Apples", 35 },
            { "Bananas", 12 },
            { "Oranges", 20 },
            { "Mangoes", 8 },
            { "Peaches", 14 }
        };

        Console.WriteLine("All stock items:");
        foreach (var item in stock)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        var lowStock = stock.Where(x => x.Value < 15);
        Console.WriteLine("\nLow stock items (< 15):");
        foreach (var item in lowStock)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        var sortedByQuantityDesc = stock.OrderByDescending(x => x.Value);
        Console.WriteLine("\nSorted by quantity (desc):");
        foreach (var item in sortedByQuantityDesc)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        Console.WriteLine($"\nAverage stock: {stock.Average(x => x.Value):F2}");
    }
}
