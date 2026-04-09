using System;
using System.Collections.Generic;

static class RemoveItems
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>() { "Mohamed", "Ahmed", "Mahmoud", "Ali" };

        Console.WriteLine("Initial names are:");
        names.ForEach(n => Console.WriteLine(n));

        // Remove item by value
        names.Remove("Mohamed");
        Console.WriteLine("\nNames after removing Mohamed are:");
        names.ForEach(n => Console.WriteLine(n));

        // Remove item by index
        names.RemoveAt(0);
        Console.WriteLine("\nNames after removing first name are:");
        names.ForEach(n => Console.WriteLine(n));

        names.RemoveAll(n => n.StartsWith("M"));
        Console.WriteLine("\nNames after removing all name which start with 'M': ");
        names.ForEach(n => Console.WriteLine(n));

        names.Clear();
        Console.WriteLine("\nAfter clearing");
        names.ForEach(n => Console.WriteLine(n));
    }
}
