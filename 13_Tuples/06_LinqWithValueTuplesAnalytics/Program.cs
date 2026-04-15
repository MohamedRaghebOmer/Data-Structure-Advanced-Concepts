using System;
using System.Collections.Generic;
using System.Linq;

static class LinqWithValueTuplesAnalytics
{
    static void Main(string[] args)
    {
        List<(string Department, string Employee, decimal Salary)> payroll =
            new List<(string, string, decimal)>
            {
                ("Engineering", "Ava", 4200m),
                ("Engineering", "Noah", 4600m),
                ("Sales", "Mia", 3900m),
                ("Sales", "Liam", 4100m),
                ("HR", "Emma", 3500m)
            };

        var averageByDepartment = payroll
            .GroupBy(x => x.Department)
            .Select(g => (Department: g.Key, AverageSalary: g.Average(x => x.Salary)))
            .OrderByDescending(x => x.AverageSalary)
            .ToArray();

        Console.WriteLine("Average Salary By Department:");
        foreach (var row in averageByDepartment)
        {
            Console.WriteLine(row.Department + " -> " + row.AverageSalary.ToString("F2"));
        }

        var topEarners = payroll
            .OrderByDescending(x => x.Salary)
            .Take(3)
            .Select(x => (x.Employee, x.Department, x.Salary))
            .ToArray();

        Console.WriteLine("\nTop 3 Salaries:");
        foreach (var item in topEarners)
        {
            Console.WriteLine(item.Employee + " (" + item.Department + ") -> " + item.Salary);
        }

        decimal totalPayroll = payroll.Sum(x => x.Salary);
        Console.WriteLine("\nTotal Payroll: " + totalPayroll);
    }
}
