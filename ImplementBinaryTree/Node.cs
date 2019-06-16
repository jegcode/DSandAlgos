using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementBinaryTree
{
    public class Node
    {
        public int key;
        public Node left, right;
        public Node(int data)
        {
            key = data;
            left = right = null;
        }
    }
}
