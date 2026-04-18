/*
SortedList with Custom Objects: Working with SortedList using custom objects
This project demonstrates using SortedList with user-defined classes.
*/

using System;
using System.Collections.Generic;
using System.Linq;

static class SortedListWithCustomObjects
{
    static void Main(string[] args)
    {
        // Create a SortedList of employees
        SortedList<int, Employee> employees = new SortedList<int, Employee>();

        employees.Add(3, new Employee { Id = 3, Name = "Charlie", Salary = 55000 });
        employees.Add(1, new Employee { Id = 1, Name = "Alice", Salary = 75000 });
        employees.Add(2, new Employee { Id = 2, Name = "Bob", Salary = 65000 });
        employees.Add(5, new Employee { Id = 5, Name = "Eve", Salary = 80000 });
        employees.Add(4, new Employee { Id = 4, Name = "David", Salary = 60000 });

        Console.WriteLine("Employees (sorted by ID):");
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value.Name}, Salary: ${emp.Value.Salary}");
        }

        // Filter high earners using LINQ
        Console.WriteLine("\nHigh earners (Salary > 60000):");
        var highEarners = employees.Where(e => e.Value.Salary > 60000);
        foreach (var emp in highEarners)
        {
            Console.WriteLine($"{emp.Value.Name}: ${emp.Value.Salary}");
        }

        // Get top earner
        var topEarner = employees.OrderByDescending(e => e.Value.Salary).FirstOrDefault();
        Console.WriteLine($"\nTop earner: {topEarner.Value.Name} (${topEarner.Value.Salary})");

        // Search for an employee
        if (employees.TryGetValue(2, out var employee))
        {
            Console.WriteLine($"\nFound: {employee.Name}");
        }
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
