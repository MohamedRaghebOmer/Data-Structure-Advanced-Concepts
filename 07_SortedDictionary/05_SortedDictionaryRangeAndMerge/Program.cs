using System;
using System.Collections.Generic;
using System.Linq;

static class SortedDictionaryRangeAndMerge
{
    static void Main()
    {
        SortedDictionary<int, decimal> monthlySales = new SortedDictionary<int, decimal>
        {
            { 1, 15000m },
            { 2, 17200m },
            { 3, 16550m },
            { 4, 19000m },
            { 5, 21000m },
            { 6, 20200m }
        };

        SortedDictionary<int, decimal> secondHalf = new SortedDictionary<int, decimal>
        {
            { 7, 22500m },
            { 8, 21800m },
            { 9, 23300m },
            { 10, 24000m },
            { 11, 25500m },
            { 12, 26500m }
        };

        foreach (var item in secondHalf)
        {
            monthlySales[item.Key] = item.Value;
        }

        Console.WriteLine("Quarter 2 sales (months 4-6):");
        foreach (var item in monthlySales.Where(x => x.Key >= 4 && x.Key <= 6))
        {
            Console.WriteLine($"Month {item.Key}: {item.Value:C}");
        }

        Console.WriteLine($"\nTotal annual sales: {monthlySales.Sum(x => x.Value):C}");
        Console.WriteLine($"Highest month sales: {monthlySales.Max(x => x.Value):C}");
    }
}
