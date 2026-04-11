using System;
using System.Collections.Generic;
using System.Linq;

static class Program
{
    static void Main(string[] args)
    {
        SortedList<int, Employee> employees = new SortedList<int, Employee>()
        {
            { 1, new Employee("Mohamed", "IT", 6000) },
            { 2, new Employee("Ahmed", "HR", 3000) },
            { 3, new Employee("Ali", "Sales", 6000) },
            { 4, new Employee("Bassem", "HR", 3000) },
            { 5, new Employee("Seif", "IT", 2000) },
            { 6, new Employee("Fady", "Sales", 6000) }
        };


        // Print employees
        Console.WriteLine("Employees:\n");
        PrintEmployees(employees);


        Console.WriteLine("\n--------------------------------------\n");

        // Group by department
        var departmentGroups = employees.GroupBy(kvp => kvp.Value.Department);
        Console.WriteLine("Group by department:");
        foreach (var group in departmentGroups)
        {
            Console.WriteLine("\nDepartment: {0}", group.Key);

            foreach (var employee in group)
            {
                Console.WriteLine("- " + GetEmployeeRecord(employee));
            }
        }


        Console.WriteLine("\n--------------------------------------\n");

        // Group by salary
        Console.WriteLine("Group by salary:");
        var salaryGroups = employees.GroupBy(kvp => kvp.Value.Salary);
        foreach (var group in salaryGroups)
        {
            Console.WriteLine("\nSalary: " + group.Key);

            foreach (var employee in group)
            {
                Console.WriteLine("- " + GetEmployeeRecord(employee));
            }
        }


        Console.WriteLine("\n--------------------------------------\n");

        // Group by whether employee name contains letter 'm' or Not
        var nameContains_m_Groups = employees.GroupBy(kvp => kvp.Value.Name.Contains("m"));
        Console.WriteLine("Group by whether employee name contains letter 'm' or not:");
        foreach (var group in nameContains_m_Groups)
        {
            Console.WriteLine("\n" + (group.Key ? "Contains 'm':" : "Does NOT contain 'm':"));

            foreach (var employee in group)
            {
                Console.WriteLine("- " + GetEmployeeRecord(employee));
            }
        }

        Console.ReadLine();
    }

    static string GetEmployeeRecord(KeyValuePair<int, Employee> employee)
    {
        return string.Format("{0}: [Name: {1}], [Department: {2}], [Salary: {3}]",
            employee.Key, employee.Value.Name, employee.Value.Department, employee.Value.Salary);
    }

    static void PrintEmployees(SortedList<int, Employee> employees)
    {
        foreach (var employee in employees)
        {
            Console.WriteLine(GetEmployeeRecord(employee));
        }
    }
}


class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, string department, decimal salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = salary;
    }
}

