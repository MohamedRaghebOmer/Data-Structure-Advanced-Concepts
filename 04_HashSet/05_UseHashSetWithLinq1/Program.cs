using System;
using System.Collections.Generic;
using System.Linq;

static class Program
{
    static void Main(string[] args)
    {
        HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Print all numbers 
        Console.WriteLine("Numbers:" + string.Join(",", numbers));

        // Print only numbers are divisible by 3
        Console.WriteLine("\nPrint all numbers divisible by 3: " + string.Join(", ", numbers.Where(n => n % 3 == 0)));

        // Print all numbers greater than 5
        Console.WriteLine("\nNumbers greater than 5: " + string.Join(", ", numbers.Where(n => n > 5)));
    }
}
