using System;
using System.Collections;

static class ArrayListCRUDOperations
{
    static void Main()
    {
        ArrayList tasks = new ArrayList { "Read", "Code", "Test" };

        tasks.Add("Deploy");
        tasks.Insert(2, "Debug");
        tasks[0] = "Plan";
        tasks.Remove("Test");

        Console.WriteLine("Tasks:");
        foreach (object task in tasks)
        {
            Console.WriteLine(task);
        }

        tasks.Clear();
        Console.WriteLine($"\nTasks count after clear: {tasks.Count}");
    }
}
