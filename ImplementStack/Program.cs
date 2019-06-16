using System;

namespace ImplementStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(5);
            for(int i = 0; i < 5; i++)
            {
                myStack.Push(i*2);
            }

            myStack.PrintStack();
            
            
        }
    }
}
