using System;
using System.Linq;

namespace Lee.CompSci.DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = GetBinaryTree();
            
            Console.WriteLine("----------------------------");
            Console.WriteLine("In-Order Traversal");
            tree.WriteOutInOrderTraversal();
            

        }

        private static BinaryTree GetBinaryTree()
        {
            return new()
            {
                RootNode = new() 
                {
                    Value = 10,
                    Left = new()
                    {
                        Value = 5,
                        Left = new() { Value = 9 },
                        Right = new() { Value = 18 }
                    },
                    Right = new()
                    {
                        Value = 20,
                        Left = new() { Value = 3 },
                        Right = new() { Value = 7}
                    }
                }     
            };
        }
    }
}