/****[ READ ME ]***************
 * Author: Dylan Buehler
 * Date: 3/15/2019
 * Filename: LinkedBasedQueue
 * Copyright: DilCoInc 2019
 ******************************/
using System;
using static System.Console;

namespace LinkedBasedQueue
{
    class Driver
    {
        static void Main(string[] args)
        {
            #region Initial Instantiations
            //Create an instance of a Queue
            Queue theQueue = new Queue();

            //Create an instance of a linked List
            LinkedList lList = new LinkedList();

            //Set the Queues List to the linked list
            theQueue.TheList = lList;

            //Create Random Number Generator
            Random num = new Random();
            #endregion

            #region Testing Code
            //Creates and adds a node to the Queue
            for (int i = 0; i < 10; i++)
            {
                CreateNode(theQueue, num);
            }//End for loop

            //Print the queue for comparison
            WriteLine("Initial Print For Comparison");
            PrintQueue(theQueue);

            //Lets look at the first value in the queue
            WriteLine("Calling the 'Peek' method");
            WriteLine($"Value: {theQueue.Peek()}");

            //Lets remove some items from the queue
            WriteLine("\nCalling the 'Dequeue' method\n");
            theQueue.Dequeue();
            WriteLine("Calling the 'Peek' method");
            WriteLine($"Value: {theQueue.Peek()}");
            WriteLine("\nCalling the 'Dequeue' method\n");
            theQueue.Dequeue();
            WriteLine("Calling the 'Peek' method");
            WriteLine($"Value: {theQueue.Peek()}");

            //Print for comparision after dequeues
            WriteLine("\nPrint For Comparison");
            PrintQueue(theQueue);

            //Remove everything
            DequeueEverything(theQueue);

            //Call Peek method to see if we get an error
            WriteLine("Calling the 'Peek' method");
            WriteLine($"Value: {theQueue.Peek()}");

            //Call Dequeue method to see if we get an error
            WriteLine("\nCalling the 'Dequeue' method");
            theQueue.Dequeue();

            //Add more to the empty queue
            WriteLine("\nAdd two entries to the queue\n");
            CreateNode(theQueue, num);
            CreateNode(theQueue, num);

            //Print the queue for comparison
            WriteLine("Print For Comparison");
            PrintQueue(theQueue);

            //To Stop To Read
            ReadKey();
            #endregion
        }//End Main Method

        /****[ CreateNode Method ]****************************
         * Expects: A Queue and Random Number
         * Returns: Nothing
         * Tasks: Creates a node, gives it a value, then calls 
         *  the Queues Enqueue method.
         *****************************************************/
        public static void CreateNode(Queue theQueue, Random num)
        {
            //Create a node
            LLNode node = new LLNode();
            
            //Give the node a value
            node.Data = num.Next(0, 100);

            //Add the node to the list using the enqueue method
            theQueue.Enqueue(node);
        }//End CreateNode
        
        /****[ PrintQueue Method ]****************************
         * Expects: The Queue
         * Returns: Nothing
         * Tasks: Check if the Queue is empty, if it is empty,
         *  print an error message. If its not empty, set the
         *  current node to the first node in the queue and
         *  then print the nodes value. Then loop untill you
         *  get to the end of the queue.
         *****************************************************/
        public static void PrintQueue(Queue theQueue)
        {
            //Error Catching
            if(theQueue.TheList.Front != null)
            {
                //Makes sure the current node is the first in the Queue
                theQueue.TheList.Current = theQueue.TheList.Front;

                do
                {
                    Write($"| {theQueue.TheList.Current.Data.ToString()} |");
                    theQueue.TheList.Current = theQueue.TheList.Current.Next;

                } while (theQueue.TheList.Current != null);
                
                WriteLine("\n");
            }
            else
            {
                WriteLine("The Queue is now empty\n");
            }//End if / else
        }//End PrintQueue
        
        /****[ DequeueEverything Method ]*********************
         * Expects: A Queue
         * Returns: Nothing
         * Tasks: Number each pass, dequeue the first node,
         *  then print the queue for comparison.
         *****************************************************/
        public static void DequeueEverything(Queue theQueue)
        {
            int num = 1;
            theQueue.TheList.Current = theQueue.TheList.Front;

            WriteLine("Calling the 'DequeueEverything' Method");
            while(theQueue.TheList.Front != null)
            {
                WriteLine($"Pass {num}");
                theQueue.Dequeue();
                PrintQueue(theQueue);
                num++;
            }//End While
        }//End DequeueEverything Method
    }//End Class
}//End Namespace