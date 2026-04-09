/*
Hashtable is a powerful, if somewhat dated, collection type in C# that excels in scenarios requiring quick access to 
elements by key. While newer, generic collections like Dictionary<TKey, TValue> offer type safety and potentially better 
performance, understanding how to use Hashtable is still valuable, especially for working with legacy code or APIs that 
require it. This lesson has equipped you with the knowledge to utilize Hashtable effectively in your C# applications.
*/

using System;
using System.Collections;

static class HashTable
{
    static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();

        // Adding key-value pairs to the hashtable
        hashtable.Add("key1", "value1");
        hashtable.Add("key2", "value2");
        hashtable.Add("key3", "value3");
        hashtable.Add("key4", "value4");

        Console.WriteLine("Hastable contents: ");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // Accessing values using keys
        Console.WriteLine("\nAccessing values using keys:");
        Console.WriteLine($"Value for key1: {hashtable["key1"]}");
        Console.WriteLine($"Value for key2: {hashtable["key2"]}");

        // Removing a key-value pair
        hashtable.Remove("key3");

        Console.WriteLine("\nHastable contents after removing key3: ");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}

