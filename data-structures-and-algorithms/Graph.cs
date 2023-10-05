﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace data_structures_and_algorithms
{
    public class Graph
    {
    }
    public class Vertex<T>
    {
        public T Value { get; set; }

        public Vertex(T value)
        {
            Value = value;
        }
    }

    public class Edge<T>
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }
    }

    public class Graph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> node = new Vertex<T>(value);

            AdjacencyList[node] = new List<Edge<T>>();
            return node;
        }

        public void AddEdge(Vertex<T> vertex1, Vertex<T> vertex2, int weight = 0)
        {
            if (!AdjacencyList.ContainsKey(vertex1) || !AdjacencyList.ContainsKey(vertex2))
            {
                throw new ArgumentException("Both vertices should already be in the graph");
            }

            AdjacencyList[vertex1].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = vertex2,
            });

            AdjacencyList[vertex2].Add(new Edge<T>
            {
                Weight = weight,
                Vertex = vertex1,
            });
        }

        public List<Vertex<T>> GetVertices()
        {
            return new List<Vertex<T>>(AdjacencyList.Keys);
        }

        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            if (AdjacencyList.ContainsKey(vertex))
            {
                return AdjacencyList[vertex];
            }
            else
            {
                return new List<Edge<T>>();
            }
        }

        public int Size()
        {
            return AdjacencyList.Count;
        }

        public void Print()
        {
            foreach (var item in AdjacencyList)
            {
                Console.Write($"Vertex {item.Key.Value} =>");

                foreach (var edge in item.Value)
                {
                    Console.Write($"{edge.Vertex.Value} (Weight: {edge.Weight}) =>");
                }

                Console.WriteLine();
            }
        }
        public ICollection<Vertex<T>> BreadthFirstTraversal(Vertex<T> startVertex)
        {
            if (!AdjacencyList.ContainsKey(startVertex))
                throw new InvalidOperationException("Start vertex is not in the graph.");

            List<Vertex<T>> visitedNodes = new List<Vertex<T>>();
            Queue<Vertex<T>> queue = new Queue<Vertex<T>>();
            HashSet<Vertex<T>> visited = new HashSet<Vertex<T>>();

            queue.Enqueue(startVertex);
            visited.Add(startVertex);

            while (queue.Count > 0)
            {
                var currentVertex = queue.Dequeue();
                visitedNodes.Add(currentVertex);

                foreach (var edge in AdjacencyList[currentVertex])
                {
                    if (!visited.Contains(edge.Vertex))
                    {
                        visited.Add(edge.Vertex);
                        queue.Enqueue(edge.Vertex);
                    }
                }
            }

            return visitedNodes;
        }
        public static int? BusinessTrip(Graph<string> graph, string[] cityNames)
        {
            if (cityNames.Length < 2)
            {
                return null;
            }

            int totalCost = 0;

            for (int i = 0; i < cityNames.Length - 1; i++)
            {
                string fromCity = cityNames[i];
                string toCity = cityNames[i + 1];

                Vertex<string> fromVertex = null;
                Vertex<string> toVertex = null;


                foreach (var vertex in graph.GetVertices())
                {
                    if (vertex.Value == fromCity)
                    {
                        fromVertex = vertex;
                    }
                    if (vertex.Value == toCity)
                    {
                        toVertex = vertex;
                    }
                }

                if (fromVertex == null || toVertex == null)
                {
                    return null;
                }

                Edge<string> edge = null;
                foreach (var neighborEdge in graph.GetNeighbors(fromVertex))
                {
                    if (neighborEdge.Vertex == toVertex)
                    {
                        edge = neighborEdge;
                    }
                }

                if (edge == null)
                {
                    return null;
                }

                totalCost += edge.Weight;
            }

            return totalCost;
        }
    }
}
