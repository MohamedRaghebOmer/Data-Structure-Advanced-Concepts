using System;
using System.Collections.Generic;
using System.Linq;

static class UseHashSetWithLinq2
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>()
        {
            "Mohamed",
            "Mostafa",
            "Mahmoud",
            "Mina",
            "Ali",
            "Ahmed",
            "Amr",
            "Omar",
            "Osama",
            "Youssef",
            "Yassin",
            "Karim",
            "Khaled",
            "Ibrahim",
            "Ismail"
        };

        // Print all names
        Console.WriteLine("All names: \n- " + string.Join("\n- ", names));

        // Print only names starts with 'M'
        Console.WriteLine("\nNames starts with 'M':\n- " + string.Join("\n- " , names.Where(n => n.StartsWith("M"))));

        // Print only names with length 4
        Console.WriteLine("\nNames with length 4:\n- " + string.Join("\n- ", names.Where(n => n.Length == 4)));

        // Pause the console
        Console.ReadLine();
    }
}
