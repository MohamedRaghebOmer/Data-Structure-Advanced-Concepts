using System;
using System.Linq;

static class AdvancedLinqOperations_2
{
    static void Main()
    {
        // Array of people with Name and Age
        var people = new[]
        {
            new { Name = "Alice", Age = 30 },
            new { Name = "Bob", Age = 25 },
            new { Name = "Charlie", Age = 35 },
            new { Name = "Diana", Age = 30 },
            new { Name = "Ethan", Age = 25 }
        };


        // Grouping people by Age, then ordering within each group
        var groupedByAge = people.GroupBy(p => p.Age).Select(
                                 group => new
                                 {
                                     Age = group.Key,
                                     People = group.OrderBy(p => p.Name)
                                 });


        // Displaying the results
        foreach (var group in groupedByAge)
        {
            Console.WriteLine($"Age Group: {group.Age}");
            foreach (var person in group.People)
            {
                Console.WriteLine($" - {person.Name}");
            }
        }
    }
}