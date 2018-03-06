

using System.Collections.Generic;

namespace lee.compsci.algos 
{
    public class Dijkstra
    {
        public Dictionary<string, int> GetShortestPath(GraphNode<string> source, Graph<string> graph)
        {
            var priorityQueue = new PriorityQueue<GraphNode<string>>();
            var distances = this.SetupDistances(source, graph);

            foreach(var node in graph)
            {
                //priorityQueue.push((GraphNode<string>)node,)
            }

            return null;
        }

        private Dictionary<GraphNode<string>, int> SetupDistances(GraphNode<string> source, Graph<string> graph)
        {
            var distances = new Dictionary<GraphNode<string>, int>();
            distances.Add(source, 0);

            foreach(var node in graph)
            {
                if (node.Value != source.Value)
                {
                    distances.Add((GraphNode<string>)node, int.MaxValue);
                }
            }

            return distances;
        }
    }
}