using System;
using System.Collections;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

static class ArrayListWithCustomObjects
{
    static void Main()
    {
        ArrayList students = new ArrayList
        {
            new Student { Name = "Sara", Age = 20 },
            new Student { Name = "Omar", Age = 22 },
            new Student { Name = "Lina", Age = 19 }
        };

        Console.WriteLine("Students:");
        foreach (Student student in students)
        {
            Console.WriteLine($"{student.Name} - {student.Age}");
        }

        students.RemoveAt(1);
        Console.WriteLine($"\nCount after RemoveAt(1): {students.Count}");
    }
}
