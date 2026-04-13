using System;
using System.Collections.ObjectModel;
using System.Linq;

static class WorkingWithObservableCollection
{
    static void Main(string[] args)
    {
        ObservableCollection<int> numbers = new ObservableCollection<int>();

        // Add elements to the collection
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);

        // Display the elements in the collection
        Console.WriteLine("Elements in the collection:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Remove an element from the collection
        numbers.Remove(2);
        Console.WriteLine("Elements in the collection after removing 2:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }


        // Check if the collection contains a specific element
        Console.WriteLine("Does the collection contain 3? " + numbers.Contains(3));

        // Clear the collection
        numbers.Clear();
        Console.WriteLine("Collection cleared. Number of elements: " + numbers.Count);
    }
}
