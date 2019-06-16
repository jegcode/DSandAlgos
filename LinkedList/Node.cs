using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    public class Node
    {

        public Node(int d)
        {
            data = d;
            next = null; 
        }

        public int data;
        public Node next;
    }
}
