using System;
using System.Collections.Generic;

static class WorkingWithHashSet
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
    }
}
