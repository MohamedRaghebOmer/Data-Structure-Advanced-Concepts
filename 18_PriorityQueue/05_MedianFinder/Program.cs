/*
Median Finder: Using two priority queues to find median in a data stream
This is a classic problem demonstrating real-world priority queue usage.
*/

using System;
using System.Collections.Generic;

static class MedianFinder
{
    static void Main(string[] args)
    {
        MedianStream medianFinder = new MedianStream();

        Console.WriteLine("=== Finding Median in Data Stream ===\n");

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Processing numbers one by one:");
        foreach (int num in numbers)
        {
            medianFinder.AddNum(num);
            Console.WriteLine($"Added {num}, Current Median: {medianFinder.FindMedian()}");
        }

        Console.WriteLine("\n\n=== Test with unordered stream ===");
        
        MedianStream medianFinder2 = new MedianStream();
        int[] unordered = { 5, 15, 1, 3, 8, 7, 9, 10, 20, 2 };

        Console.WriteLine("Processing unordered numbers:");
        foreach (int num in unordered)
        {
            medianFinder2.AddNum(num);
            Console.WriteLine($"Added {num}, Current Median: {medianFinder2.FindMedian()}");
        }
    }
}

class MedianStream
{
    private PriorityQueue<int, int> maxHeap;
    private PriorityQueue<int, int> minHeap;

    public MedianStream()
    {
        maxHeap = new PriorityQueue<int, int>();
        minHeap = new PriorityQueue<int, int>();
    }

    public void AddNum(int num)
    {
        if (maxHeap.Count == 0 || num <= GetMaxHeapTop())
        {
            maxHeap.Enqueue(num, -num);
        }
        else
        {
            minHeap.Enqueue(num, num);
        }

        // Balance the heaps
        if (maxHeap.Count > minHeap.Count + 1)
        {
            int element = maxHeap.Dequeue();
            minHeap.Enqueue(element, element);
        }
        else if (minHeap.Count > maxHeap.Count)
        {
            int element = minHeap.Dequeue();
            maxHeap.Enqueue(element, -element);
        }
    }

    public double FindMedian()
    {
        if (maxHeap.Count + minHeap.Count == 0)
            return 0;

        if (maxHeap.Count == minHeap.Count)
        {
            return (GetMaxHeapTop() + GetMinHeapTop()) / 2.0;
        }
        else
        {
            return GetMaxHeapTop();
        }
    }

    private int GetMaxHeapTop()
    {
        if (maxHeap.Count == 0)
            return 0;

        var list = new List<int>();
        while (maxHeap.Count > 0)
        {
            list.Add(maxHeap.Dequeue());
        }

        int max = list[0];
        foreach (int num in list)
        {
            maxHeap.Enqueue(num, -num);
        }

        return max;
    }

    private int GetMinHeapTop()
    {
        if (minHeap.Count == 0)
            return 0;

        var list = new List<int>();
        while (minHeap.Count > 0)
        {
            list.Add(minHeap.Dequeue());
        }

        int min = list[0];
        foreach (int num in list)
        {
            minHeap.Enqueue(num, num);
        }

        return min;
    }
}
