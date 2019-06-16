using System;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lList = new LinkedList();

            lList.ListItems();
            lList.AddEnd(1);
            lList.ListItems();
            lList.AddEnd(2);
            lList.ListItems();
            lList.AddEnd(3);
            lList.ListItems();
            lList.DeleteNode(2);
            lList.ListItems();
    
        } 
        
    }
}
