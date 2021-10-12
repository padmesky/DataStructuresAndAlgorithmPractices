using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataStructuresAndAlgorithmPractise.Apps.Util
{
    public class Edge : IComparable<Edge>
    {
        private int from;
        private int to;
        private double weight;

        public Edge(int from, int to, double weight)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }

        public int From() 
        {
            return this.from;
        }

        public int To() 
        {
            return this.to;
        }

        public double Weight() 
        {
            return this.weight;
        }

        public Edge Reverse() 
        {
            return new Edge(this.to, this.from, this.weight);
        }

        public int CompareTo([AllowNull] Edge other)
        {
            return this.weight.CompareTo(other.weight);
        }
    }
}
