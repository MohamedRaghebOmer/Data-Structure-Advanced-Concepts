/*
Performance Comparison: Comparing different data structures
This project demonstrates performance characteristics of various collection types.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

static class PerformanceComparison
{
    static void Main(string[] args)
    {
        const int itemCount = 100000;

        Console.WriteLine("=== Data Structure Performance Comparison ===\n");

        // List Performance
        TestListPerformance(itemCount);

        // LinkedList Performance
        TestLinkedListPerformance(itemCount);

        // Dictionary Performance
        TestDictionaryPerformance(itemCount);

        // HashSet Performance
        TestHashSetPerformance(itemCount);

        Console.WriteLine("\n=== Summary ===");
        Console.WriteLine("List: Best for indexed access, worst for insertions");
        Console.WriteLine("LinkedList: Best for insertions, worst for access");
        Console.WriteLine("Dictionary: Best for key-value lookups");
        Console.WriteLine("HashSet: Best for unique items and membership testing");
    }

    static void TestListPerformance(int count)
    {
        var list = new List<int>();
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < count; i++)
            list.Add(i);

        sw.Stop();
        Console.WriteLine($"List Add: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        int access = 0;
        for (int i = 0; i < count; i++)
            access = list[i];
        sw.Stop();
        Console.WriteLine($"List Access: {sw.ElapsedMilliseconds} ms");
    }

    static void TestLinkedListPerformance(int count)
    {
        var linkedList = new LinkedList<int>();
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < count; i++)
            linkedList.AddLast(i);

        sw.Stop();
        Console.WriteLine($"\nLinkedList Add: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        int access = 0;
        foreach (var item in linkedList)
            access = item;
        sw.Stop();
        Console.WriteLine($"LinkedList Iteration: {sw.ElapsedMilliseconds} ms");
    }

    static void TestDictionaryPerformance(int count)
    {
        var dict = new Dictionary<int, string>();
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < count; i++)
            dict[i] = $"Value{i}";

        sw.Stop();
        Console.WriteLine($"\nDictionary Add: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        for (int i = 0; i < count; i++)
        {
            string val;
            dict.TryGetValue(i, out val);
        }
        sw.Stop();
        Console.WriteLine($"Dictionary Lookup: {sw.ElapsedMilliseconds} ms");
    }

    static void TestHashSetPerformance(int count)
    {
        var hashSet = new HashSet<int>();
        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < count; i++)
            hashSet.Add(i);

        sw.Stop();
        Console.WriteLine($"\nHashSet Add: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        bool found = false;
        for (int i = 0; i < count; i++)
            found = hashSet.Contains(i);
        sw.Stop();
        Console.WriteLine($"HashSet Contains: {sw.ElapsedMilliseconds} ms");
    }
}
