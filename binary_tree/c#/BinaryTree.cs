namespace Lee.CompSci.DataStructures
{
    public class Node 
    {
        public string Name { get; set; }  
        public Node[] Children { get; set; }
    }

    public class BinaryNode
    {
        public int Value { get; set; }
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }
    }
    
    public class Tree
    {
        public Node RootNode { get; set; }
    }

    public class BinaryTree
    {
        public BinaryNode RootNode { get; set; }
    }
}