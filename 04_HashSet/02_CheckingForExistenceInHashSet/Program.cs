using System;
using System.Collections.Generic;

static class CheckingForExistenceInHashSet
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
        Console.WriteLine("Does the hash set contain 'Banana'? " + fruits.Contains("Banana"));
        Console.WriteLine("Does the hash set contain 'Pineapple'? " + fruits.Contains("Pineapple"));
        Console.WriteLine("Does the hash set contain 'Grapes'? " + fruits.Contains("Grapes"));
    }
}
