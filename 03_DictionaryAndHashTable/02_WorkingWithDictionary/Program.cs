using System;
using System.Collections.Generic;

static class WorkingWithDictionary
{
    static void Main(string[] args)
    {
        // Initializing the dictionary
        Dictionary<string, int> fruitBasket = new Dictionary<string, int>();

        fruitBasket.Add("Apple", 5);
        fruitBasket.Add("Banana", 3);
        fruitBasket.Add("Orange", 7);
        // The following commented line will cause an error because the key [Orange] is already has been added.
        //fruitBasket.Add("Orange", 1);

        Console.WriteLine("Fruit basket content: ");
        foreach (KeyValuePair<string, int> item in fruitBasket)
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");

        // Remove value [Apple] from the dictionary
        fruitBasket.Remove("Apple");

        Console.WriteLine("\nFruit basket after removing apple is:");
        foreach (var item in fruitBasket)
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
    }
}

