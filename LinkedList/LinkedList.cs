using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
   public class LinkedList
    {
       public Node head;
       public string message;

        //View List Items
        public void ListItems() {

            Node n;
            if (head != null)
            {
                n = head;
            } else
            {
                message = "The list is empty";
                Console.WriteLine(message);
                return;
            }
           
            while(n != null)
            {
                Console.Write(n.data + ",");
                n = n.next;
            }

            Console.WriteLine("");
           
        }

        //Add a node to the beginning of the List
        public void AddNode(int data)
        {

            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode; 
        }


        //Add a node after a given node
        public void AppendNode(Node givenNode, int data)
        {

            if(givenNode == null)
            {
                Console.WriteLine("The given node cannot be null");
                return;
            }

            Node newNode = new Node(data);
            newNode.next = givenNode.next;
            givenNode.next = newNode; 
        }

        //Add a node to the end of the List
        public void AddEnd(int data)
        {

            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.next = null;
            Node last = head;

            while(last.next != null)
            {
                last = last.next;
            }

            last.next = newNode; 
              
        }


        //Delete an item from the List
        public void DeleteNode(int key)
        {
            Node temp = head;
            Node prev = null;

            if(temp != null && temp.data == key)
            {
                head = temp.next;
                return;
            }

            while( temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next; 
            }

            if (temp == null) return;

            prev.next = temp.next; 
        }
    }
}
