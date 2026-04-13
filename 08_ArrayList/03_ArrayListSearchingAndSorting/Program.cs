using System;
using System.Collections;

static class ArrayListSearchingAndSorting
{
    static void Main()
    {
        ArrayList numbers = new ArrayList { 42, 7, 19, 3, 15, 8 };

        numbers.Sort();
        Console.WriteLine("Sorted numbers:");
        foreach (object number in numbers)
        {
            Console.WriteLine(number);
        }

        int target = 19;
        int index = numbers.BinarySearch(target);
        Console.WriteLine($"\nIndex of {target}: {index}");

        numbers.Reverse();
        Console.WriteLine("\nDescending order:");
        foreach (object number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
