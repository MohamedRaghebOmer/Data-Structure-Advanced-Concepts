/*
Boxing with Collections: Using System.Collections with boxing
This project demonstrates how value types are boxed when added to non-generic collections.
*/

using System;
using System.Collections;

static class BoxingWithCollections
{
    static void Main(string[] args)
    {
        // Using ArrayList (non-generic) - demonstrates boxing
        ArrayList list = new ArrayList();

        // Boxing integers
        list.Add(10);
        list.Add(20);
        list.Add(30);

        // Boxing custom structs
        Point p = new Point { X = 5, Y = 10 };
        list.Add(p);

        Console.WriteLine("ArrayList Contents (with boxing):");
        foreach (object item in list)
        {
            Console.WriteLine($"Item: {item}, Type: {item.GetType()}");
        }

        // Unboxing example
        Console.WriteLine("\nUnboxing from ArrayList:");
        int firstValue = (int)list[0];
        Point unboxedPoint = (Point)list[3];

        Console.WriteLine($"First integer value: {firstValue}");
        Console.WriteLine($"Point from ArrayList: X={unboxedPoint.X}, Y={unboxedPoint.Y}");
    }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"Point({X}, {Y})";
    }
}
