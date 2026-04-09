using System;
using System.Collections.Generic;

static class TryGetValue
{
    static void Main(string[] args)
    {
        Dictionary<int, string> Students = new Dictionary<int, string>();

        Students.Add(1, "Student1");
        Students.Add(2, "Student2");
        Students.Add(3, "Student3");

        if (Students.TryGetValue(34, out string value))
        {
            Console.WriteLine($"Value of key 3 is: {value}");
        }
        else
        {
            Console.WriteLine("Value not found.");
        }
    }
}
