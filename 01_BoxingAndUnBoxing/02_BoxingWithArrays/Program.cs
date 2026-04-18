/*
Boxing with Arrays: Demonstrating boxing value types in arrays
This project shows how boxing occurs when storing value types in object arrays.
*/

using System;

static class BoxingWithArrays
{
    static void Main(string[] args)
    {
        // Create an object array (reference type array)
        object[] mixedArray = new object[5];

        // Boxing integers into object array
        mixedArray[0] = 42;
        mixedArray[1] = 100;
        mixedArray[2] = 250;

        // Boxing doubles
        mixedArray[3] = 3.14;

        // Boxing strings (already reference type)
        mixedArray[4] = "Hello";

        Console.WriteLine("Elements in mixed array (boxed values):");
        foreach (object item in mixedArray)
        {
            Console.WriteLine(item);
        }

        // Unboxing elements back to their original types
        Console.WriteLine("\nUnboxing values:");
        int num1 = (int)mixedArray[0];
        int num2 = (int)mixedArray[1];
        double num3 = (double)mixedArray[3];

        Console.WriteLine($"First number: {num1}");
        Console.WriteLine($"Second number: {num2}");
        Console.WriteLine($"Double value: {num3}");

        Console.WriteLine($"\nType of first boxed value: {mixedArray[0].GetType()}");
        Console.WriteLine($"Type of double value: {mixedArray[3].GetType()}");
    }
}
