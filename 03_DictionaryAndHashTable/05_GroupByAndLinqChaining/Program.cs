using System;
using System.Collections.Generic;
using System.Linq;

static class GroupByAndLinqChaining
{
    static void Main(string[] args)
    {
        //-----------GroupBy with List-----------
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        IEnumerable<IGrouping<bool, int>> groupsEvenOdd = numbers.GroupBy(n => n % 2 == 0);
        foreach (IGrouping<bool, int> group in groupsEvenOdd)
        {
            // Print the group key (name). If the group key true then print 'Even' otherwise print 'Odd'.
            Console.WriteLine(group.Key ? "\nEven" : "Odd");

            // Print each group values (numbers)
            foreach (int num in group)
            {
                Console.WriteLine("- " + num);
            }
        }

        //-----------GroupBy with Dictionary-----------
        Dictionary<string, string> Words = new Dictionary<string, string>
        {
            { "w1", "apple" },
            { "w2", "ant" },
            { "w3", "banana" },
            { "w4", "bat" },
            { "w5", "car" },
            { "w6", "cat" },
            { "w7", "dog" },
            { "w8", "door" },
            { "w9", "elephant" },
            { "w10", "egg" }
        };

        Console.WriteLine("\n--------Group by first letter--------");

        // Group by first letter
        var startWithGroups = Words.GroupBy(w => w.Value[0]);
        foreach(var group in startWithGroups)
        {
            Console.WriteLine($"Starts with: {group.Key}");

            // Print all words in each group
            foreach (var word in group)
            {
                Console.WriteLine("- " + word.Value);
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n--------Group by length--------");

        // Group by word length
        var lengthGroups = Words.GroupBy(w => w.Value.Length);
        foreach (var group in lengthGroups)
        {
            Console.WriteLine($"Length: {group.Key}");

            foreach (var word in group)
            {
                Console.WriteLine("- " + word.Value);
            }
            Console.WriteLine();
        }


        //-----------Linq chaining-----------

        var startWith_c_OrderedAsc = Words
            .Where(w => w.Value[0] == 'c')
            .OrderByDescending(w => w.Key)
            .Select(w => w.Key + ": " + w.Value);
        Console.WriteLine("\nWords start with 'c' ordered by key desc:");
        foreach (string word in startWith_c_OrderedAsc)
        {
            Console.WriteLine(word);
        }
    }
}

