using System;

namespace lee.compsci.algos
{
    class Program
    {
        static void Main(string[] args)
        {
            var dijkstra = new Dijkstra();
            var graph = GetGraph();
            var source = (GraphNode<string>)graph.Nodes.FindByValue("u");
            var result = dijkstra.GetShortestPath(source, graph);
            
        }

        static Graph<string> GetGraph() 
        {
            var u = new GraphNode<string>(){Value = "u"};
            var v = new GraphNode<string>(){Value = "v"};
            var w = new GraphNode<string>(){Value = "w"};
            var x = new GraphNode<string>(){Value = "x"};
            var y = new GraphNode<string>(){Value = "y"};
            var z = new GraphNode<string>(){Value = "z"};

            var graph = new Graph<string>();
            graph.AddNode(u);
            graph.AddNode(v);
            graph.AddNode(w);
            graph.AddNode(x);
            graph.AddNode(y);
            graph.AddNode(z);

            graph.AddUndirectedEdge(u, v, 1);
            graph.AddUndirectedEdge(u, w, 2);

            graph.AddUndirectedEdge(v, u, 1);
            graph.AddUndirectedEdge(v, w, 3);
            graph.AddUndirectedEdge(v, x, 2);

            graph.AddUndirectedEdge(w, u, 5);
            graph.AddUndirectedEdge(w, v, 3);
            graph.AddUndirectedEdge(w, x, 3);
            graph.AddUndirectedEdge(w, y, 1);
            graph.AddUndirectedEdge(w, z, 5);

            graph.AddUndirectedEdge(x, u, 1);
            graph.AddUndirectedEdge(x, v, 2);
            graph.AddUndirectedEdge(x, w, 3);
            graph.AddUndirectedEdge(x, y, 1);

            graph.AddUndirectedEdge(y, x, 1);
            graph.AddUndirectedEdge(y, w, 1);
            graph.AddUndirectedEdge(y, z, 1);

            graph.AddUndirectedEdge(z, w, 5);
            graph.AddUndirectedEdge(y, y, 1);

            return graph;
        }
    }
}
