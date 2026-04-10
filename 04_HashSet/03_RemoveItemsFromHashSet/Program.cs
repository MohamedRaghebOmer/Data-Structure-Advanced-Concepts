using System;
using System.Collections.Generic;

static class RemoveItemsFromHashSet
{
    static void Main(string[] args)
    {
        // Initialize the hash set
        HashSet<string> fruits = new HashSet<string>();

        // Add some fruits to the hash set
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Grapes");
        fruits.Add("Mango");

        fruits.Add("Apple"); // This will not be added again, as it's a duplicate

        // Display the fruits in the hash set
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        // Check if fruits contains a specific fruit
        Console.WriteLine("\nDoes the hash set contain 'Banana'? " + fruits.Contains("Banana"));
        Console.WriteLine("Does the hash set contain 'Pineapple'? " + fruits.Contains("Pineapple"));
        Console.WriteLine("Does the hash set contain 'Grapes'? " + fruits.Contains("Grapes"));

        // Remove a fruit from the hash set
        fruits.Remove("Banana");
        fruits.Remove("Pineapple"); // This will not do anything, as 'Pineapple' is not in the hash set

        // Display the fruits in the hash set after removal
        Console.WriteLine("\nFruits in the hash set after removal:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Clear the hash set
        fruits.Clear();

        // Display the fruits in the hash set after clearing
        Console.WriteLine("\nFruits in the hash set after clearing:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
