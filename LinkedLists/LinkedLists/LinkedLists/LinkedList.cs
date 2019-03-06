using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
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