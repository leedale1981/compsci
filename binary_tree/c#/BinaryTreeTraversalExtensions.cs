using System;

namespace Lee.CompSci.DataStructures
{
    public static class BinaryTreeTraversalExtensions
    {
        public static void WriteOutInOrderTraversal(this BinaryTree tree)
        {
            InOrderTraversal(tree.RootNode);
        }

        private static void InOrderTraversal(BinaryNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Value);
                InOrderTraversal(node.Right);
            }
        }

        public static void WriteOutPreOrderTraversal(this BinaryTree tree)
        {
            PreOrderTraversal(tree.RootNode);
        }

        private static void PreOrderTraversal(BinaryNode node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }

        public static void WriteOutPostOrderTraversal(this BinaryTree tree)
        {
            PostOrderTraversal(tree.RootNode);
        }

        private static void PostOrderTraversal(BinaryNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.WriteLine(node.Value);
            }
        }
    }
}