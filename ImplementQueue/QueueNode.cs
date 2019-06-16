using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementQueue
{
    public class QueueNode
    {

        public int data; 
        public QueueNode next; 

        public QueueNode(int d )
        {
            data = d; 
            next = null; 
        }


    }
}
