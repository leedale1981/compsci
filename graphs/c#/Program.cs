using System;
using System.Text.Json;

namespace Lee.CompSci.DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = GetDirectedFriendsGraph();
            var meNode = graph.GetNode(new() { Value = "Me" });
            var tomNode = graph.GetNode(new() { Value = "Tom" });
            var path = graph.FindPathDepthFirst(meNode, tomNode);

            Console.WriteLine($"Path taken from Me to Tom is {JsonSerializer.Serialize(path).ToString()}");
            Console.WriteLine($"Distance between Me and Tom is {path.Count}");
        }

        private static Graph<string> GetDirectedFriendsGraph()
        {
            Graph<string> graph = new();
            GraphNode<string> me = new() { Value = "Me" };
            GraphNode<string> steve = new() { Value = "Steve" };
            GraphNode<string> alex = new() { Value = "Alex" };
            GraphNode<string> paul = new() { Value = "Paul" };
            GraphNode<string> tom = new() { Value = "Tom" };

            graph.AddNode(me);
            graph.AddNode(steve);
            graph.AddNode(alex);
            graph.AddNode(paul);
            graph.AddNode(tom);

            graph.AddEdge(me, steve);
            graph.AddEdge(me, paul);
            graph.AddEdge(me, alex);

            graph.AddEdge(steve, me);
            graph.AddEdge(steve, alex);

            graph.AddEdge(alex, steve);
            graph.AddEdge(alex, me);

            graph.AddEdge(paul, me);
            graph.AddEdge(paul, tom);

            return graph;
        }
    }
}