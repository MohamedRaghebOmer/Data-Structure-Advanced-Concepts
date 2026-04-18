/*
Heap Sorting: Using heaps to perform sorting operations
This project demonstrates the heap sort algorithm using min and max heaps.
*/

using System;
using System.Collections.Generic;

static class HeapSorting
{
    static void Main(string[] args)
    {
        int[] numbers = { 64, 34, 25, 12, 22, 11, 90, 88, 45, 50 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        // Heap sort
        HeapSort(numbers);

        Console.WriteLine("\nArray after Heap Sort:");
        PrintArray(numbers);

        // Using built-in PriorityQueue for demonstration
        Console.WriteLine("\nUsing Priority Queue for sorting (ascending):");
        var pq = new PriorityQueue<int, int>();
        int[] numbers2 = { 64, 34, 25, 12, 22, 11, 90, 88, 45, 50 };

        foreach (int num in numbers2)
        {
            pq.Enqueue(num, num);
        }

        Console.Write("Sorted: ");
        while (pq.Count > 0)
        {
            Console.Write(pq.Dequeue() + " ");
        }
        Console.WriteLine();
    }

    static void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }

    static void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            int temp = arr[i];
            arr[i] = arr[largest];
            arr[largest] = temp;

            Heapify(arr, n, largest);
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
