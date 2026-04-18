/*
Priority Queue with Heap: Implementing a custom priority queue using heaps
This project demonstrates how to build a priority queue from scratch.
*/

using System;
using System.Collections.Generic;

static class PriorityQueueWithHeap
{
    static void Main(string[] args)
    {
        PriorityQueue pq = new PriorityQueue();

        Console.WriteLine("=== Custom Priority Queue (Min-Heap) ===\n");

        // Insert elements
        pq.Insert(5);
        pq.Insert(3);
        pq.Insert(7);
        pq.Insert(1);
        pq.Insert(9);
        pq.Insert(2);

        Console.WriteLine("Inserted: 5, 3, 7, 1, 9, 2");

        Console.WriteLine("\nExtracting elements in priority order:");
        while (!pq.IsEmpty())
        {
            Console.Write(pq.ExtractMin() + " ");
        }
        Console.WriteLine();

        // Test with strings
        Console.WriteLine("\n\n=== Priority Queue with Custom Objects ===");
        
        PriorityQueueString pqs = new PriorityQueueString();
        pqs.Insert("High Priority", 1);
        pqs.Insert("Low Priority", 5);
        pqs.Insert("Medium Priority", 3);
        pqs.Insert("Critical", 0);

        Console.WriteLine("\nProcessing in priority order:");
        while (!pqs.IsEmpty())
        {
            var item = pqs.ExtractMin();
            Console.WriteLine($"  {item.Item}: Priority {item.Priority}");
        }
    }
}

class PriorityQueue
{
    private List<int> heap;

    public PriorityQueue()
    {
        heap = new List<int>();
    }

    public void Insert(int value)
    {
        heap.Add(value);
        HeapifyUp(heap.Count - 1);
    }

    public int ExtractMin()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        int min = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        if (heap.Count > 0)
            HeapifyDown(0);

        return min;
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
            if (heap[index] < heap[parent])
            {
                int temp = heap[index];
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

            if (left < heap.Count && heap[left] < heap[smallest])
                smallest = left;

            if (right < heap.Count && heap[right] < heap[smallest])
                smallest = right;

            if (smallest != index)
            {
                int temp = heap[index];
                heap[index] = heap[smallest];
                heap[smallest] = temp;
                index = smallest;
            }
            else
                break;
        }
    }
}

class PriorityQueueString
{
    private List<(string Item, int Priority)> heap;

    public PriorityQueueString()
    {
        heap = new List<(string, int)>();
    }

    public void Insert(string item, int priority)
    {
        heap.Add((item, priority));
        HeapifyUp(heap.Count - 1);
    }

    public (string Item, int Priority) ExtractMin()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        var min = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);

        if (heap.Count > 0)
            HeapifyDown(0);

        return min;
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
