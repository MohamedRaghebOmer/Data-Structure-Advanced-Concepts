/*
Boxing Performance: Comparing boxing and unboxing performance
This project demonstrates the performance implications of boxing operations.
*/

using System;
using System.Diagnostics;

static class BoxingPerformance
{
    static void Main(string[] args)
    {
        const int iterations = 10000000;
        
        // Test 1: Generic List (no boxing)
        Stopwatch sw = Stopwatch.StartNew();
        TestGenericList(iterations);
        sw.Stop();
        Console.WriteLine($"Generic List (no boxing): {sw.ElapsedMilliseconds} ms");

        // Test 2: Non-generic ArrayList (with boxing)
        sw.Restart();
        TestArrayList(iterations);
        sw.Stop();
        Console.WriteLine($"ArrayList (with boxing): {sw.ElapsedMilliseconds} ms");

        // Test 3: Direct boxing and unboxing
        sw.Restart();
        TestDirectBoxing(iterations);
        sw.Stop();
        Console.WriteLine($"Direct boxing/unboxing: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine("\nConclusion: Boxing has performance overhead compared to generics");
    }

    static void TestGenericList(int count)
    {
        System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
        for (int i = 0; i < count; i++)
        {
            list.Add(i);
            int value = list[i];
        }
    }

    static void TestArrayList(int count)
    {
        System.Collections.ArrayList list = new System.Collections.ArrayList();
        for (int i = 0; i < count; i++)
        {
            list.Add(i);
            int value = (int)list[i];
        }
    }

    static void TestDirectBoxing(int count)
    {
        for (int i = 0; i < count; i++)
        {
            object boxed = i;
            int unboxed = (int)boxed;
        }
    }
}
