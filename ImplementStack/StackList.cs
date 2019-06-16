using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementStack
{
    public class StackList
    {
        public StackNode root;
        public string message; 

        public void Push(int data)
        {
            StackNode newItem = new StackNode(data);

            if (root == null)
            {   
                root = newItem;

            } else
            {
                StackNode tmp = root; 
                root = newItem;
                newItem.next = tmp; 
            }
            message = $"{data} pushed to the stack";
            Console.WriteLine(message);
        }

        public int Pop()
        {
            int popped = int.MinValue;
            if (root == null)
            {
                return popped; 
            } else
            {
                popped = root.data;
                root = root.next;         
            }
            return popped;
        }

        public int Peek()
        {
           if (root == null)
            {
                return int.MinValue; 
            } else
            {
                return root.data; 
            }
        }

        public bool IsEmpty()
        {
           if(root == null)
            {
                return true; 
            } else
            {
                return false; 
            }
        }
    }
}
