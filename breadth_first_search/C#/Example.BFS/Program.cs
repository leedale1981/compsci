Node node1 = new Node(1);
Node node2 = new Node(2);
Node node3 = new Node(3);
Node node4 = new Node(4);
Node node5 = new Node(5);
node1.Vertices = new[] { new Vertex(node2), new Vertex(node3) };
node2.Vertices = new[] { new Vertex(node1), new Vertex(node5), new Vertex(node3), new Vertex(node4)  };
node3.Vertices = new[] { new Vertex(node2), new Vertex(node4) };
node4.Vertices = new[] { new Vertex(node2), new Vertex(node5), new Vertex(node3) };
node5.Vertices = new[] { new Vertex(node4), new Vertex(node1), new Vertex(node2) };
Node[] nodes = [node1, node2, node3, node4, node5];
Graph graph = new(nodes);

Console.WriteLine($"Found value {graph.Bfs(3).Value}");
Console.WriteLine($"Found value {graph.Dfs(3).Value}");

public record Node(int Value)
{
    public Vertex[] Vertices { get; set; } = [];
}

public record Graph(Node[] Nodes)
{
    public Node Bfs(int value)
    {
        int stepCounter = 0;
        
        foreach (Node node in Nodes)
        {
            stepCounter++;
            
            if (node.Value == value)
            {
                Console.WriteLine($"Steps taken: {stepCounter}");
                return node;
            }

            foreach (Vertex vertex in node.Vertices)
            {
                stepCounter++;
                
                if (vertex.Connection.Value == value)
                {
                    Console.WriteLine($"Steps taken: {stepCounter}");
                    return vertex.Connection;
                }
            }
        }
        
        return null;
    }
    
    public Node Dfs(int value)
    {
        int stepCounter = 0;
        
        foreach (Node node in Nodes)
        {
            stepCounter++;
            
            if (node.Value == value)
            {
                Console.WriteLine($"Steps taken: {stepCounter}");
                return node;
            }

            SearchVerticesRecusively(node.Vertices, value, stepCounter);
        }
        
        return null;
    }

    private Node SearchVerticesRecusively(Vertex[] vertices, int value, int stepCounter)
    {
        foreach (Vertex vertex in vertices)
        {
            stepCounter++;
            
            if (vertex.Connection.Value == value)
            {
                Console.WriteLine($"Steps taken: {stepCounter}");
                return vertex.Connection;
            }

            return SearchVerticesRecusively(vertex.Connection.Vertices, value, stepCounter);
        }

        return null;
    }
}

public record Vertex(Node Connection)
{

}


