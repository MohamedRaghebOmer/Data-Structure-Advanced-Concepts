using System;
using System.Collections.Generic;

static class WorkingWithTuples
{
    static void Main(string[] args)
    {
        // Declare a tuple
        Tuple<int, string, double> person1 = new Tuple<int, string, double>(32, "Mohamed", 192.3);
        (int, string, double) person2 = (22, "Ahmed", 185.23);


        // Accessing tuple items
        Console.WriteLine($"Person1:\nId: {person1.Item1}, Name: {person1.Item2}, Hight: {person1.Item3}");
        Console.WriteLine($"\nPerson2:\nId: {person2.Item1}, Name: {person2.Item2}, Hight: {person2.Item3}");

        // Using method that returning tuples
        Console.WriteLine($"\nTuple Method:\nId: {TupleMethod().Item1}, Name: {TupleMethod().Item2}, Hight: {TupleMethod().Item3}");
    }

    static (int, string, double) TupleMethod()
    {
        return (4, "string", 32.3);
    }
}

