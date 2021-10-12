using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithmPractise.Apps.Util
{
    public class DepthFirstSearch
    {
        private Graph graph;
        private bool[] marked;
        private int source;
        private int connectedVertices;

        public DepthFirstSearch(Graph graph, int source) 
        {
            this.graph = graph;
            this.source = source;
            marked = new bool[graph.vertices];
            dfs(source);
        }
        
        public bool hasPathTo(int v)
        {
            return marked[v];
        }

        public int ConnectedVertices() 
        {
            return connectedVertices;
        }
        private void dfs(int v) 
        {
            marked[v] = true;
            connectedVertices++;
            foreach (var vertex in graph.adjacencyVertices(v))
            {
                if (!marked[vertex]) 
                {
                    dfs(vertex);
                }
            }
        }
    }
}
