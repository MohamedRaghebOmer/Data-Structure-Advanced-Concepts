/*
Task Scheduler: Using Priority Queue to manage task scheduling
This project demonstrates a real-world application of priority queues.
*/

using System;
using System.Collections.Generic;

static class TaskScheduler
{
    static void Main(string[] args)
    {
        TaskQueue scheduler = new TaskQueue();

        Console.WriteLine("=== Task Scheduler using Priority Queue ===\n");

        // Add tasks with different priorities
        scheduler.AddTask("Fix critical bug", 1);
        scheduler.AddTask("Update documentation", 5);
        scheduler.AddTask("Implement new feature", 3);
        scheduler.AddTask("Deploy to production", 2);
        scheduler.AddTask("Code review", 4);

        Console.WriteLine("Tasks scheduled for processing:\n");

        while (!scheduler.IsEmpty())
        {
            Task task = scheduler.GetNextTask();
            Console.WriteLine($"Processing: {task.Description} (Priority: {task.Priority})");
        }

        Console.WriteLine("\n\n=== Real-Time Priority Update Example ===");
        
        scheduler.AddTask("Write unit tests", 4);
        scheduler.AddTask("Security audit", 3);
        scheduler.AddTask("System maintenance", 1);

        Console.WriteLine("\nProcessing updated task list:");
        while (!scheduler.IsEmpty())
        {
            Task task = scheduler.GetNextTask();
            Console.WriteLine($"Processing: {task.Description} (Priority: {task.Priority})");
        }
    }
}

class Task
{
    public string Description { get; set; }
    public int Priority { get; set; }
    public DateTime CreatedAt { get; set; }

    public Task(string description, int priority)
    {
        Description = description;
        Priority = priority;
        CreatedAt = DateTime.Now;
    }
}

class TaskQueue
{
    private List<Task> heap;

    public TaskQueue()
    {
        heap = new List<Task>();
    }

    public void AddTask(string description, int priority)
    {
        Task task = new Task(description, priority);
        heap.Add(task);
        HeapifyUp(heap.Count - 1);
    }

    public Task GetNextTask()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("No tasks in queue");

        Task nextTask = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        if (heap.Count > 0)
            HeapifyDown(0);

        return nextTask;
    }

    public bool IsEmpty()
    {
        return heap.Count == 0;
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parent = (index - 1) / 2;
            if (heap[index].Priority < heap[parent].Priority)
            {
                var temp = heap[index];
                heap[index] = heap[parent];
                heap[parent] = temp;
                index = parent;
            }
            else
                break;
        }
    }

    private void HeapifyDown(int index)
    {
        while (true)
        {
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < heap.Count && heap[left].Priority < heap[smallest].Priority)
                smallest = left;

            if (right < heap.Count && heap[right].Priority < heap[smallest].Priority)
                smallest = right;

            if (smallest != index)
            {
                var temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;
                index = smallest;
            }
            else
                break;
        }
    }
}
