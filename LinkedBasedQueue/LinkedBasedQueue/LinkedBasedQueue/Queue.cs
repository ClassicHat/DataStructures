/****[ READ ME ]***************
 * Author: Dylan Buehler
 * Date: 3/15/2019
 * Filename: LinkedBasedQueue
 * Copyright: DilCoInc 2019
 ******************************/
using static System.Console;

namespace LinkedBasedQueue
{
    class Queue
    {
        private LinkedList theList;

        public LinkedList TheList { get => theList; set => theList = value; }

        //Default Constructor
        public Queue(){}
        
        /****[ Enqueue Method ]*******************************
         * Expects: A LLNode
         * Returns: Nothing
         * Tasks: When given a LLNode if the list is empty,
         *  the node is added to the list and the front,
         *  back, and current properties are updated. If the
         *  list is not empty, set the back properties node
         *  to point to the next node. Then set the back of 
         *  the list to the next node.
         * ***************************************************/
        public void Enqueue(LLNode theNode)
        {
            if(theList.Current == null)
            {
                theList.Front = theNode;
                theList.Back = theNode;
                theList.Current = theNode;
            }
            else
            {
                theList.Back.Next = theNode;
                theList.Back = theNode;
            }//End if / else
        }//End Enqueue Method
        
        /****[ Dequeue Method ]*******************************
         * Expects: Nothing
         * Returns: Nothing
         * Tasks: If the queue is not empty, set a reference
         *  to the second node in the queue and make it the
         *  current node. Then set the front node to the
         *  current node. If the queue is empty, write to the
         *  console and error message.
         *****************************************************/
        public void Dequeue()
        {
            if(theList.Front != null)
            {
                //Set a reference to the second node in the queue
                theList.Current = theList.Front.Next;

                //Set the Front to the Current - can be null
                theList.Front = theList.Current;
            }
            else
            {
                WriteLine("Hand Shake Failed - 'Dequeue' method - The Queue is empty");
            }//End if / else
        }//End Dequeue Method
        
        /****[ Peek Method ]**********************************
         * Expects: Nothing
         * Returns: Nothing
         * Tasks: Return the first value in the queue if the
         *  queue is not empty.
         *****************************************************/
        public string Peek()
        {
            //Error Catching
            if (theList.Front != null)
            {
                return theList.Front.Data.ToString();
            }
            else
            {
                return "Hand Shake Failed - 'Peek' method - The Queue is empty";
            }//End if / else
        }//End Peek Method
    }//End Class
}//End Namespace