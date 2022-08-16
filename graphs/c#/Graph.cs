namespace Lee.CompSci.DataStructures
{
    public class DirectedGraph
    {
        public DirectedGraphNode RootNode { get; set; }
    }

    public class DirectedGraphNode
    {
        public int Value { get; set; }
        public DirectedGraphNode[] InNodes { get; set; }
        public DirectedGraphNode[] OutNodes { get; set; }
    }

    public class UndirectedGraph
    {
        public UndirectedGraphNode RootNode { get; set; }
    }

    public class UndirectedGraphNode
    {
        public int Value { get; set; }
        public UndirectedGraphNode[] Nodes { get; set; }
    }
}