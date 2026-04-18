/*
ObservableCollection Advanced Scenarios: Complex use cases with ObservableCollection
This project demonstrates filtering, sorting, and synchronization with ObservableCollection.
*/

using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

static class ObservableCollectionAdvancedScenarios
{
    static void Main(string[] args)
    {
        ObservableCollection<Task> tasks = new ObservableCollection<Task>();

        tasks.CollectionChanged += (sender, e) =>
        {
            Console.WriteLine($"[CHANGE] {e.Action}: {e.NewItems?.Count ?? 0} new items, {e.OldItems?.Count ?? 0} removed");
        };

        // Add tasks
        tasks.Add(new Task { Id = 1, Title = "Design Database", Status = "In Progress", Priority = 2 });
        tasks.Add(new Task { Id = 2, Title = "Implement API", Status = "Pending", Priority = 1 });
        tasks.Add(new Task { Id = 3, Title = "Write Tests", Status = "Pending", Priority = 3 });
        tasks.Add(new Task { Id = 4, Title = "Deploy to Production", Status = "Blocked", Priority = 1 });

        Console.WriteLine("\n--- All Tasks ---");
        DisplayTasks(tasks);

        // Filter high priority tasks
        Console.WriteLine("\n--- High Priority Tasks (Priority <= 1) ---");
        var highPriority = FilterTasks(tasks, t => t.Priority <= 1);
        DisplayTasks(highPriority);

        // Get pending tasks
        Console.WriteLine("\n--- Pending Tasks ---");
        var pending = FilterTasks(tasks, t => t.Status == "Pending");
        DisplayTasks(pending);

        // Update task status
        Console.WriteLine("\n--- Completing 'Implement API' ---");
        tasks[1].Status = "Completed";

        Console.WriteLine("\n--- Final Task List ---");
        DisplayTasks(tasks);

        // Summary statistics
        Console.WriteLine($"\nTotal tasks: {tasks.Count}");
        Console.WriteLine($"Completed: {GetTaskCount(tasks, t => t.Status == "Completed")}");
        Console.WriteLine($"Pending: {GetTaskCount(tasks, t => t.Status == "Pending")}");
    }

    static ObservableCollection<Task> FilterTasks(ObservableCollection<Task> tasks, Func<Task, bool> predicate)
    {
        var filtered = new ObservableCollection<Task>();
        foreach (var task in tasks)
        {
            if (predicate(task))
                filtered.Add(task);
        }
        return filtered;
    }

    static int GetTaskCount(ObservableCollection<Task> tasks, Func<Task, bool> predicate)
    {
        int count = 0;
        foreach (var task in tasks)
        {
            if (predicate(task))
                count++;
        }
        return count;
    }

    static void DisplayTasks(ObservableCollection<Task> tasks)
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"  {task.Id}. [{task.Status}] {task.Title} (Priority: {task.Priority})");
        }
    }
}

class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Status { get; set; }
    public int Priority { get; set; }
}
