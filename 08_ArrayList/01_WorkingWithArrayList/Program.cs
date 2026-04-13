using System;
using System.Collections;

static class WorkingWithArrayList
{
    static void Main()
    {
        ArrayList values = new ArrayList { 10, "Hello", 3.14, true };
        values.Add("ArrayList");
        values.Insert(1, "Inserted Item");

        Console.WriteLine("ArrayList contents:");
        foreach (object item in values)
        {
            Console.WriteLine(item);
        }

        values.Remove("Hello");
        Console.WriteLine($"\nCount after removal: {values.Count}");
    }
}
