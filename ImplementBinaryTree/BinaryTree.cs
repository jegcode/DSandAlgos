using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementBinaryTree
{
   public class BinaryTree
    {
        public Node root;

        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        public BinaryTree()
        {
            root = null; 
        }

       public void PrintInOrder(Node node)
        {
            if (node == null)
                return;

            PrintInOrder(node.left);
            Console.Write(node.key + " ");
            PrintInOrder(node.right);
        }
    }
}
