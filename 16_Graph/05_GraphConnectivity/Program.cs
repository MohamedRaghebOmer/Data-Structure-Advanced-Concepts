/*
Graph Connectivity: Checking if a graph is connected (using Union-Find)
This project demonstrates how to determine connectivity in undirected graphs.
*/

using System;
using System.Collections.Generic;

static class GraphConnectivity
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Graph Connectivity Check ===\n");

        // Test case 1: Connected graph
        Console.WriteLine("Test 1: Connected Graph");
        int[] parent1 = UnionFind.CreateParent(5);
        UnionFind.Union(parent1, 0, 1);
        UnionFind.Union(parent1, 1, 2);
        UnionFind.Union(parent1, 2, 3);
        UnionFind.Union(parent1, 3, 4);

        if (IsConnected(parent1, 5))
            Console.WriteLine("✓ Graph is connected");
        else
            Console.WriteLine("✗ Graph is not connected");

        // Test case 2: Disconnected graph
        Console.WriteLine("\nTest 2: Disconnected Graph");
        int[] parent2 = UnionFind.CreateParent(5);
        UnionFind.Union(parent2, 0, 1);
        UnionFind.Union(parent2, 1, 2);
        UnionFind.Union(parent2, 3, 4);

        if (IsConnected(parent2, 5))
            Console.WriteLine("✓ Graph is connected");
        else
            Console.WriteLine("✗ Graph is not connected");

        // Test case 3: Finding connected components
        Console.WriteLine("\nTest 3: Finding Connected Components");
        int[] parent3 = UnionFind.CreateParent(6);
        UnionFind.Union(parent3, 0, 1);
        UnionFind.Union(parent3, 1, 2);
        UnionFind.Union(parent3, 3, 4);

        int components = CountConnectedComponents(parent3, 6);
        Console.WriteLine($"Number of connected components: {components}");

        // Test case 4: Cycle detection
        Console.WriteLine("\nTest 4: Cycle Detection");
        Console.WriteLine(HasCycle(4, new[] { (0, 1), (1, 2), (2, 3), (3, 1) }) ? 
            "✓ Graph has a cycle" : 
            "✗ Graph has no cycle");
    }

    static bool IsConnected(int[] parent, int n)
    {
        int root = UnionFind.Find(parent, 0);
        for (int i = 1; i < n; i++)
        {
            if (UnionFind.Find(parent, i) != root)
                return false;
        }
        return true;
    }

    static int CountConnectedComponents(int[] parent, int n)
    {
        HashSet<int> roots = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            roots.Add(UnionFind.Find(parent, i));
        }
        return roots.Count;
    }

    static bool HasCycle(int vertices, (int, int)[] edges)
    {
        int[] parent = UnionFind.CreateParent(vertices);

        foreach (var (u, v) in edges)
        {
            int rootU = UnionFind.Find(parent, u);
            int rootV = UnionFind.Find(parent, v);

            if (rootU == rootV)
                return true;

            UnionFind.Union(parent, u, v);
        }

        return false;
    }
}

class UnionFind
{
    public static int[] CreateParent(int n)
    {
        int[] parent = new int[n];
        for (int i = 0; i < n; i++)
            parent[i] = i;
        return parent;
    }

    public static int Find(int[] parent, int x)
    {
        if (parent[x] != x)
            parent[x] = Find(parent, parent[x]);
        return parent[x];
    }

    public static void Union(int[] parent, int x, int y)
    {
        int rootX = Find(parent, x);
        int rootY = Find(parent, y);

        if (rootX != rootY)
            parent[rootX] = rootY;
    }
}
