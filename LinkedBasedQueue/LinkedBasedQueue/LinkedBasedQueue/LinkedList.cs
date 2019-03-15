/****[ READ ME ]***************
 * Author: Dylan Buehler
 * Date: 3/15/2019
 * Filename: LinkedBasedQueue
 * Copyright: DilCoInc 2019
 ******************************/
namespace LinkedBasedQueue
{
    class LinkedList
    {
        private LLNode front;
        private LLNode back;
        private LLNode current;

        public LLNode Front { get => front; set => front = value; }
        public LLNode Back { get => back; set => back = value; }
        public LLNode Current { get => current; set => current = value; }

        //Default Constructor
        public LinkedList(){}
    }//End Linked List
}//End Namespace