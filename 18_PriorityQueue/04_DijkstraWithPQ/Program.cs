/*
Dijkstra with Priority Queue: Implementing Dijkstra's algorithm using a priority queue
This project shows an optimized implementation of Dijkstra's shortest path algorithm.
*/

using System;
using System.Collections.Generic;

static class DijkstraWithPQ
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(6);

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

        Console.WriteLine("=== Dijkstra's Algorithm with Priority Queue ===\n");

        int source = 0;
        graph.DijkstraWithPriorityQueue(source);
    }
}

class Node : IComparable<Node>
{
    public int Vertex { get; set; }
    public int Distance { get; set; }

    public Node(int vertex, int distance)
    {
        Vertex = vertex;
        Distance = distance;
    }

    public int CompareTo(Node other)
    {
        return this.Distance.CompareTo(other.Distance);
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

class Graph
{
    private int vertices;
    private List<Edge>[] adjacencyList;

    public Graph(int vertices)
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

    public void DijkstraWithPriorityQueue(int source)
    {
        int[] distances = new int[vertices];
        bool[] visited = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            distances[i] = int.MaxValue;
        }

        distances[source] = 0;

        PriorityQueue<Node, Node> pq = new PriorityQueue<Node, Node>();
        pq.Enqueue(new Node(source, 0), new Node(source, 0));

        while (pq.Count > 0)
        {
            Node current = pq.Dequeue();

            if (visited[current.Vertex])
                continue;

            visited[current.Vertex] = true;

            foreach (Edge edge in adjacencyList[current.Vertex])
            {
                int neighbor = edge.To;
                int weight = edge.Weight;

                if (!visited[neighbor] && distances[current.Vertex] + weight < distances[neighbor])
                {
                    distances[neighbor] = distances[current.Vertex] + weight;
                    pq.Enqueue(new Node(neighbor, distances[neighbor]), new Node(neighbor, distances[neighbor]));
                }
            }
        }

        Console.WriteLine($"Shortest distances from vertex {source}:");
        for (int i = 0; i < vertices; i++)
        {
            Console.WriteLine($"Vertex {i}: {(distances[i] == int.MaxValue ? "∞" : distances[i].ToString())}");
        }
    }
}
