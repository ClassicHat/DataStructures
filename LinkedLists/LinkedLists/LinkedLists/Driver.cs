using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Instantiate a new node
            LLNode node = new LLNode();

            //Give the node a value
            node.Data = 0;

            //Create a instance of a linked list
            LinkedList list = new LinkedList();

            //Add the current node to the list
            list.Front = node;
            list.Back = node;
            list.Current = node;

            //Create a new node
            LLNode node2 = new LLNode();

            //point to the new node
            node.Next = node2;

            //give node2 a value
            node2.Data = 1;

            //Add node2 to the linked list
            list.Back = node2.Next;

            //Create another node
            LLNode node3 = new LLNode();

            //point to the new node
            node2.Next = node3;

            //give node3 a value
            node3.Data = 2;

            //Add node3 to the linked list
            list.Back = node3.Next;

            //Print the elements of the linked list
            Console.WriteLine(list.Current.Data.ToString());
            list.Current = list.Current.Next;
            Console.WriteLine(list.Current.Data.ToString());
            list.Current = list.Current.Next;
            Console.WriteLine(list.Current.Data.ToString());

            //Readkey to stop program
            Console.ReadKey();
            
        }
    }
}
