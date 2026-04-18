/*
Graph Shortest Path: Implementing Dijkstra's algorithm
This project demonstrates finding the shortest path between nodes in a weighted graph.
*/

using System;
using System.Collections.Generic;
using System.Linq;

static class GraphShortestPath
{
    static void Main(string[] args)
    {
        WeightedGraph graph = new WeightedGraph(6);

        // Add weighted edges
        graph.AddEdge(0, 1, 4);
        graph.AddEdge(0, 2, 2);
        graph.AddEdge(1, 2, 1);
        graph.AddEdge(1, 3, 5);
        graph.AddEdge(2, 3, 8);
        graph.AddEdge(2, 4, 10);
        graph.AddEdge(3, 4, 2);
        graph.AddEdge(3, 5, 6);
        graph.AddEdge(4, 5, 3);

        Console.WriteLine("=== Dijkstra's Shortest Path Algorithm ===\n");

        int source = 0;
        int destination = 5;

        graph.Dijkstra(source);
        Console.WriteLine($"\nShortest distances from vertex {source}:");
    }
}

class Edge
{
    public int To { get; set; }
    public int Weight { get; set; }

    public Edge(int to, int weight)
    {
        To = to;
        Weight = weight;
    }
}

class WeightedGraph
{
    private int vertices;
    private List<Edge>[] adjacencyList;

    public WeightedGraph(int vertices)
    {
        this.vertices = vertices;
        adjacencyList = new List<Edge>[vertices];

        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<Edge>();
        }
    }

    public void AddEdge(int u, int v, int weight)
    {
        adjacencyList[u].Add(new Edge(v, weight));
        adjacencyList[v].Add(new Edge(u, weight));
    }

    public void Dijkstra(int source)
    {
        int[] distances = new int[vertices];
        bool[] visited = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            distances[i] = int.MaxValue;
        }

        distances[source] = 0;

        for (int count = 0; count < vertices - 1; count++)
        {
            int u = -1;
            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v] && distances[v] != int.MaxValue)
                {
                    if (u == -1 || distances[v] < distances[u])
                        u = v;
                }
            }

            if (u == -1)
                break;

            visited[u] = true;

            foreach (Edge edge in adjacencyList[u])
            {
                int v = edge.To;
                int weight = edge.Weight;

                if (!visited[v] && distances[u] + weight < distances[v])
                {
                    distances[v] = distances[u] + weight;
                }
            }
        }

        for (int i = 0; i < vertices; i++)
        {
            Console.WriteLine($"Vertex {i}: {(distances[i] == int.MaxValue ? "∞" : distances[i].ToString())}");
        }
    }
}
