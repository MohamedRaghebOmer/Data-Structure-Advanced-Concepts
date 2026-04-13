using System;
using System.Linq;

static class AdvancedLinqOperations_4
{
    static void Main()
    {
        // Array of employees
        var employees = new[]
        {
            new { Id = 1, Name = "Alice", DepartmentId = 2 },
            new { Id = 2, Name = "Bob", DepartmentId = 1 }
        };


        // Array of departments
        var departments = new[]
        {
            new { Id = 1, Name = "Human Resources" },
            new { Id = 2, Name = "Development" }
        };


        // Joining employees with departments and projecting the result
        var employeeDetails = employees.Join(departments,
                                             e => e.DepartmentId,
                                             d => d.Id,
                                             (e, d) => new { e.Name, Department = d.Name });


        // Displaying the results
        foreach (var detail in employeeDetails)
        {
            Console.WriteLine($"Employee: {detail.Name}, Department: {detail.Department}");
        }
    }
}