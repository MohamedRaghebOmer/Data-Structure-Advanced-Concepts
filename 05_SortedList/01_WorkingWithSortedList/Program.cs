/*
SortedList in C# is a useful collection for scenarios where automatic sorting of elements is required. 
*/

using System;
using System.Collections.Generic;

static class WorkingWithSortedList
{
    static void Main(string[] args)
    {
        // Declaring the sorted list
        SortedList<string, int> list = new SortedList<string, int>() { };

        // Add new elements
        list.Add("Apple", 4);
        list.Add("Orange", 2);
        list.Add("Banana", 7);

        // Print the elements
        Console.WriteLine("Elements in sorted list:");
        foreach (var item in list)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }

        // Removing an element by key
        list.Remove("Apple");

        Console.WriteLine("\nElements after removing 'Apple':");
        foreach (var item in list)
        {
            Console.WriteLine("{0}: {1}", item.Key, item.Value);
        }
    }
}
