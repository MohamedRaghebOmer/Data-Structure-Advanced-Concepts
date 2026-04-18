/*
Graph BFS and DFS: Implementing Breadth-First Search and Depth-First Search
This project demonstrates two fundamental graph traversal algorithms.
*/

using System;
using System.Collections.Generic;

static class GraphBFS_DFS
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(6);

        // Add edges (undirected)
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);

        Console.WriteLine("=== Graph Traversals ===\n");

        Console.WriteLine("BFS (Breadth-First Search) starting from vertex 0:");
        graph.BFS(0);
        Console.WriteLine();

        Console.WriteLine("DFS (Depth-First Search) starting from vertex 0:");
        graph.DFS(0);
        Console.WriteLine();

        Console.WriteLine("\nBFS from vertex 3:");
        graph.BFS(3);
        Console.WriteLine();

        Console.WriteLine("DFS from vertex 3:");
        graph.DFS(3);
        Console.WriteLine();
    }
}

class Graph
{
    private int vertices;
    private List<int>[] adjacencyList;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjacencyList = new List<int>[vertices];

        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adjacencyList[u].Add(v);
        adjacencyList[v].Add(u);
    }

    public void BFS(int startVertex)
    {
        bool[] visited = new bool[vertices];
        Queue<int> queue = new Queue<int>();

        visited[startVertex] = true;
        queue.Enqueue(startVertex);

        while (queue.Count > 0)
        {
            int vertex = queue.Dequeue();
            Console.Write(vertex + " ");

            foreach (int neighbor in adjacencyList[vertex])
            {
                if (!visited[neighbor])
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                }
            }
        }
    }

    public void DFS(int startVertex)
    {
        bool[] visited = new bool[vertices];
        DFSRecursive(startVertex, visited);
    }

    private void DFSRecursive(int vertex, bool[] visited)
    {
        visited[vertex] = true;
        Console.Write(vertex + " ");

        foreach (int neighbor in adjacencyList[vertex])
        {
            if (!visited[neighbor])
            {
                DFSRecursive(neighbor, visited);
            }
        }
    }
}
