using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementStack
{
    public class StackNode
    {
        public int data;
        public StackNode next;
        public StackNode(int d)
        {
            data = d; 
        }
    }
}
