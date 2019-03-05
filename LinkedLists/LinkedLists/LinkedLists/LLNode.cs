using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class LLNode
    {
        private int data;
        private int next;

        public int Data { get => data; set => data = value; }
        public int Next { get => next; set => next = value; }

        public LLNode()
        {
            data = Data;
            next = Next;
        }//End Constructor
    }//End Class LLNode
}//End Namespace