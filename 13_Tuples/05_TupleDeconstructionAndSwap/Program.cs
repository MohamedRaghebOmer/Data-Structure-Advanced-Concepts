using System;
using System.Collections.Generic;

static class TupleDeconstructionAndSwap
{
    static void Main(string[] args)
    {
        (int Id, string Name, string Role) employee = (12, "Mia", "Developer");
        var (id, name, _) = employee;
        Console.WriteLine("Deconstruction -> Id: " + id + ", Name: " + name);

        int first = 10;
        int second = 25;
        (first, second) = (second, first);
        Console.WriteLine("Swap -> First: " + first + ", Second: " + second);

        foreach (var (product, quantity) in BuildOrderLines())
        {
            Console.WriteLine("Order Line -> Product: " + product + ", Quantity: " + quantity);
        }
    }

    static List<(string Product, int Quantity)> BuildOrderLines()
    {
        return new List<(string, int)>
        {
            ("Keyboard", 2),
            ("Mouse", 4),
            ("Monitor", 1)
        };
    }
}
