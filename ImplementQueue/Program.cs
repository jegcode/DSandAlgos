using System;

namespace ImplementQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
       

            myQueue.ViewQueue();
            myQueue.Dequeue();
            myQueue.ViewQueue(); 
           
        }
    }
}
