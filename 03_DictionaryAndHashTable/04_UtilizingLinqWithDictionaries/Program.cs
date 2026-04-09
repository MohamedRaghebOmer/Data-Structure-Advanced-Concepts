using System;
using System.Collections.Generic;
using System.Linq;

static class UtilizingLinqWithDictionaries
{
    static void Main(string[] args)
    {
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 3 },
            { "Orange", 7 }
        };


        // Select
        IEnumerable<string> valueTimes3 = fruitBasket.Select(v => v.Key + ": " + v.Value);
        Console.WriteLine("Fruits are:");
        foreach (string item in valueTimes3)
        {
            Console.WriteLine(item);
        }


        // Where
        IEnumerable<KeyValuePair<string, int>> valueGreaterThan3 = fruitBasket.Where(v => v.Value > 3);
        Console.WriteLine("\nFruits with values greater than 3:");
        foreach (var item in valueGreaterThan3)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }


        // OrderBy
        IEnumerable<KeyValuePair<string, int>> orderedByKeyAsc = fruitBasket.OrderBy(k => k.Key);
        Console.WriteLine("\nFruits ordered by names Ascending: ");
        foreach (var item in orderedByKeyAsc)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }


        // OrderByDesc
        IEnumerable<KeyValuePair<string, int>> orderedByKeyDesc = fruitBasket.OrderByDescending(k => k.Key);
        Console.WriteLine("\nFruits ordered by name descending:");
        foreach (KeyValuePair<string, int> fruit in orderedByKeyDesc)
        {
            Console.WriteLine($"{fruit.Key}: {fruit.Value}");
        }


        // Sum
        int valuesSum = fruitBasket.Sum(v => v.Value);
        Console.WriteLine($"\nValues sum is: {valuesSum}");


        // Any => (Returns true if any element satisfies the condition)
        bool anyValueGreaterThan3 = fruitBasket.Any(n => n.Value > 3);
        Console.WriteLine($"Is there any value greater than 3: {anyValueGreaterThan3}");


        // All => (Returns true if all the elements satisfies the condition)
        bool allValuesGreaterThan3 = fruitBasket.All(v => v.Value > 3);
        Console.WriteLine($"All values are greater than 3: {allValuesGreaterThan3}");


        // Max => (Returns the greatest value in the elements)
        int longestFruitNameLength = fruitBasket.Max(k => k.Key.Length);
        Console.WriteLine($"Longest key name length is: {longestFruitNameLength}");


        // Count (Count the number of all elements without condition)
        int fruitBasketCount = fruitBasket.Count;
        Console.WriteLine($"Fruit basket count: {fruitBasketCount}");


        // Count() => (Count all elements satisfies a specified condition)
        int nameLengthGreaterThan5Count = fruitBasket.Count(k => k.Key.Length > 5);
        Console.WriteLine($"Number of fruit name length exceeds 5: {nameLengthGreaterThan5Count}");
    }
}

