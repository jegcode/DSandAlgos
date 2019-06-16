using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementStack
{
   public class Stack
    {
        public int[] items;
        public int top;
        public int max;

        public Stack(int size)
        {
            items = new int[size];
            top = -1;
            max = size;
        }

        public void Push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
            } else
            {
                items[++top] = item;
            }
        }

        public int Peek()
        {
            if (top == -1)
            {
                return -1;
            } else
            {
                return items[top];
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                return -1;
            } else
            {
                return items[top--];
            }
        }


        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            } else
            {
                return false; 
            }
        }

        public void PrintStack()
        {
            if (top == -1)
            {
                Console.WriteLine("The Stack is Empty");
                return;
            } else
            {
                Console.WriteLine("The contents of the stack are:");
                for(int i = 0; i < max; i++)
                {
                    Console.Write($" Item: {items[i]} , ");
                }
                Console.WriteLine("");
            }
        }


    }
}
