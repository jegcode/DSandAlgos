using System;
using System.Collections.Generic;
using System.Text;
 

namespace ImplementQueue
{
    public class Queue
    {
        QueueNode front, rear;

        public Queue()
        {
            front = null;
            rear = null; 
        }

        public void Enqueue(int data)
        {
            QueueNode temp = new QueueNode(data);

            if(rear == null)
            {
                front = temp;
                rear = temp;
                return;
            }

            rear.next = temp;
            rear = temp; 
        }

        public QueueNode Dequeue()
        {
            if(front == null)
            {
                return null; 
            }

            QueueNode temp = front;
            front = front.next;

            if(front == null)
            {
                rear = null; 
            }

            return temp; 
        }


        public int Front()
        {
            if (front == null && rear == null)
            {
                Console.WriteLine("The queue is empty");
                return int.MinValue; 
            }
            else
            {
                return front.data; 
            }
        }

        public int Rear()
        {
            if (front == null && rear == null)
            {
                Console.WriteLine("The queue is empty");
                return int.MinValue;
            }
            else
            {
                return rear.data; 
            }
        }

        public void ViewQueue()
        {
            QueueNode f = front;

            Console.WriteLine("The items in the queue are: ");
            if (rear == null && front == null)
            {
                Console.WriteLine("The queue is empty");
            } else
            {
                
                while(f != null)
                {
                    
                    Console.Write(f.data + ",");
                    f = f.next;


                }
                Console.WriteLine("");
            }

        }


    }
}
