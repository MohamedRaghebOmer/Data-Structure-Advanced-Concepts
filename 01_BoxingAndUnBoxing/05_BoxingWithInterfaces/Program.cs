/*
Boxing with Interfaces: Demonstrating boxing when using interface types
This project shows how boxing occurs when storing value types through interface references.
*/

using System;

static class BoxingWithInterfaces
{
    static void Main(string[] args)
    {
        // Boxing value types through interface reference
        IComparable comparable1 = 42;           // Boxing int
        IComparable comparable2 = 3.14;         // Boxing double
        IComparable comparable3 = "Hello";      // String (already reference type)

        Console.WriteLine("Boxed values through IComparable interface:");
        Console.WriteLine($"Value 1: {comparable1}, Type: {comparable1.GetType()}");
        Console.WriteLine($"Value 2: {comparable2}, Type: {comparable2.GetType()}");
        Console.WriteLine($"Value 3: {comparable3}, Type: {comparable3.GetType()}");

        // Using interface method
        int comparison = comparable1.CompareTo(100);
        Console.WriteLine($"\nComparison result (42 vs 100): {comparison}");

        // Unboxing with interface
        Console.WriteLine("\nUnboxing from interface:");
        if (comparable1 is int intValue)
        {
            Console.WriteLine($"Successfully unboxed int: {intValue}");
        }

        // Working with custom interface
        IProcessor processor = new Temperature { Celsius = 25 };
        Console.WriteLine($"\nCustom interface boxing: {processor}");
    }
}

interface IProcessor
{
    void Process();
}

struct Temperature : IProcessor
{
    public double Celsius { get; set; }

    public void Process()
    {
        Console.WriteLine($"Processing temperature: {Celsius}°C");
    }

    public override string ToString()
    {
        return $"{Celsius}°C";
    }
}
