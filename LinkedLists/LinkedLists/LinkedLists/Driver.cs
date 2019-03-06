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
            //Variables
            bool isEmpty = true;
            Random randNum = new Random();

            //Create a instance of a linked list
            LinkedList list = new LinkedList();


            for(int i = 0; i < 10; i++)
            {
                //Call the create node method
                CreateNode(list, isEmpty, randNum);
                //Set isEmpty to false
                isEmpty = false;
            }
            
            while(list.Current != list.Back.Next)
            {
                Console.WriteLine(list.Current.Data.ToString());
                list.Current = list.Current.Next;
            }//End While

            //Readkey to stop program
            Console.ReadKey();
            
        }//End Main Method

        public static void CreateNode(LinkedList list, bool isEmpty, Random randNum)
        {
            //Instantiate a new node
            LLNode node = new LLNode();

            //isEmpty = true - Enters the if statement if the linked list is empty
            if(isEmpty)
            {
                //Give the node a value
                node.Data = randNum.Next(0, 100);

                //Add the current node to the list
                list.Front = node;
                list.Back = node;
                list.Current = node;
            }
            else
            {
                // list.Back.Next - the last node in the list
                // setting the pointer to the new node
                list.Back.Next = node;

                //give the new node a value
                node.Data = randNum.Next(0, 100);

                //Add node to the linked list
                list.Back = node;
            }//End if / else
        }//End Create Node
    }//End Class
}//End Namespace