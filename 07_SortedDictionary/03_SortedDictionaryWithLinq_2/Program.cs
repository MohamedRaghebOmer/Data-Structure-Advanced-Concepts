using System;
using System.Collections.Generic;
using System.Linq;

static class SortedDictionaryWithLinq_2
{
    static void Main()
    {
        SortedDictionary<string, int> scores = new SortedDictionary<string, int>
        {
            { "Aarav", 91 },
            { "Diya", 76 },
            { "Ishaan", 88 },
            { "Meera", 95 },
            { "Riya", 69 },
            { "Vivaan", 84 }
        };

        Console.WriteLine("Top 3 scores:");
        foreach (var student in scores.OrderByDescending(x => x.Value).Take(3))
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }

        var grouped = scores.GroupBy(x => x.Value >= 75 ? "Pass" : "Fail");
        Console.WriteLine("\nGrouped by result:");
        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var student in group)
            {
                Console.WriteLine($"  {student.Key} - {student.Value}");
            }
        }

        Console.WriteLine($"\nClass average: {scores.Average(x => x.Value):F2}");
    }
}
