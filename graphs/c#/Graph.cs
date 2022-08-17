using System;
using System.Collections.Generic;

namespace Lee.CompSci.DataStructures
{
    public class Graph<TValue>
    {
        private List<GraphNode<TValue>> _nodes = new List<GraphNode<TValue>>();

        public void AddNode(GraphNode<TValue> node)
        {
            _nodes.Add(node);
        }
        public void AddEdge(GraphNode<TValue> sourceNode, GraphNode<TValue> destinationNode)
        {
            sourceNode.Nodes.Add(destinationNode);
        }

        public GraphNode<TValue> GetNode(GraphNode<TValue> node)
        {
            return _nodes.Find(n => n.Value.Equals(node.Value));
        }

        public List<string> FindPathDepthFirst(GraphNode<TValue> startNode, GraphNode<TValue> endNode)
        {
            List<string> path = new();
            path.Add(startNode.Value.ToString());

            bool foundTarget = false;
            GraphNode<TValue> nextNode = startNode.Nodes[0];
            int nextIndex = 0;

            while (!foundTarget)
            {
                if (nextNode.Value.Equals(startNode.Value))
                {
                    nextIndex++;
                }
                else
                {
                    path.Add(nextNode.Value.ToString());
                    foundTarget = nextNode.Value.Equals(endNode.Value);
                }

                if (nextIndex >= nextNode.Nodes.Count)
                {
                    nextIndex = 0;
                }

                if (nextNode.Nodes.Count > 0)
                {
                    nextNode = nextNode.Nodes[nextIndex];
                }
            }

            return path;
        }

        // public GraphNode<TValue> FindPathBreadthFirst(GraphNode<TValue> startNode, GraphNode<TValue> endNode)
        // {

        // }
    }

    public class GraphNode<TValue>
    {
        public TValue Value { get; set; }
        public List<GraphNode<TValue>> Nodes { get; set; } = new List<GraphNode<TValue>>();
    }
}