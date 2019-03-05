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

        public LinkedList()
        {
            front = Front;
            back = Back;
            current = Current;
        }//End Linked List Constructor
    }//End Linked List
}//End Namespace