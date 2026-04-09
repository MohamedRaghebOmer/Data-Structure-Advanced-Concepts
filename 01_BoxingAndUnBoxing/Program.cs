/*
                                Boxing
• Boxing is the process of converting a value type to a reference type.
• This involves wrapping a value type (like int, float, char) in an object or any interface type implemented by this value type.
• During boxing, the value is wrapped inside an object instance and stored in the heap.
• Boxing is a fundamental concept in C#, allowing value types to be treated as objects While it is necessary in certain scenarios, developers should be aware of its performance implications.

• Compatibility with Object Types: In .NET, every type eventually derives from the System.Object class.
• Boxing allows value types, which are not objects in themselves, to be treated as objects.
• This is crucial in scenarios where a method expects an object type or when you need to store value types in a data structure that holds objects.


                            Unboxing
• Unboxing is the reverse process of Boxing, where the value type is extracted from the object.
• It's crucial to ensure the type being unboxed matches the type of the object.
• Unboxing requires the exact data type match; otherwise, it results in InvalidCastException.
• Unboxing is a critical operation in C# that retrieves value types from objects. Proper type matching is essential for successful unboxing.

*/

using System;

static class BoxingAndUnBoxing
{
    static void Main(string[] args)
    {
        // Boxing
        int i = 123;
        object obj = i; // Boxing

        Console.WriteLine(i);   // Output: 123
        Console.WriteLine(obj); // Output: 123

        // Unboxing
        int j = (int)obj; // Unboxing
        Console.WriteLine(j); // Output: 123
    }
}
