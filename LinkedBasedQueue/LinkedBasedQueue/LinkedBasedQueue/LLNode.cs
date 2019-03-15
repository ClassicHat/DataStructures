/****[ READ ME ]***************
 * Author: Dylan Buehler
 * Date: 3/15/2019
 * Filename: LinkedBasedQueue
 * Copyright: DilCoInc 2019
 ******************************/
namespace LinkedBasedQueue
{
    class LLNode
    {
        private int data;
        private LLNode next;

        public int Data { get => data; set => data = value; }
        public LLNode Next { get => next; set => next = value; }

        //Default Constructor
        public LLNode(){}
    }//End Class LLNode
}//End Namespace