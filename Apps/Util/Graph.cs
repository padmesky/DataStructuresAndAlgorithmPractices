using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithmPractise.Apps.Util
{
    public class Graph
    {
        public int vertices;
        public int edges;
        public LinkedList<Edge>[] adjacencyList;

        public Graph(int vertices) 
        {
            this.vertices = vertices;
            adjacencyList = new LinkedList<Edge>[vertices];

            for (int i = 0; i < adjacencyList.Length; i++)
            {
                adjacencyList[i] = new LinkedList<Edge>();
            }
        }

        public void AddEdge(int from, int to, double weight) 
        {
            edges++;
            adjacencyList[from].InsertEnd(new Edge(from, to, weight));
            adjacencyList[to].InsertEnd(new Edge(to, from, weight));
        }

        public LinkedList<Edge> Edges() 
        {
            LinkedList<Edge> list = new LinkedList<Edge>();

            for (int i = 0; i < vertices; i++)
            {
                foreach (var edge in adjacencyList[i])
                {
                    list.Add(edge);
                }
            }

            return list;
        }

        public LinkedList<int> adjacencyVertices(int v) 
        {
            LinkedList<int> list = new LinkedList<int>();

            foreach (var edge in adjacencyList[v])
            {
                list.Add(edge.To());
            }

            return list;
        }

    }
}
