using System;
using System.Collections;
using System.Linq;

static class ArrayListWithLinqCast
{
    static void Main()
    {
        ArrayList values = new ArrayList { 5, 10, 15, 20, 25, 30 };

        var evenNumbers = values.Cast<int>().Where(x => x % 2 == 0);
        Console.WriteLine("Even numbers:");
        foreach (int number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        int sum = values.Cast<int>().Sum();
        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Average: {values.Cast<int>().Average():F2}");
    }
}
