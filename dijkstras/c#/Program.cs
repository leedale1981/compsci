using System;

namespace lee.compsci.algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var dijkstra = new Dijkstra(GetGraph());

        }

        static Graph<string> GetGraph() 
        {
            var graph = new Graph<string>() 
            {
                new GraphNode<string>() 
                {

                }
            };
        }
    }
}
