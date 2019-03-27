using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedStack
{
    class ArrayStack
    {
        private int capacity;
        private int size;
        private ArrayList stack;

        public int Capacity { get => capacity; set => capacity = value; }
        public int Size { get => size; set => size = value; }
        public ArrayList Stack { get => stack; set => stack = value; }

        //Default Constructor
        public ArrayStack(ArrayList theStack, int maxSize)
        {
            Stack = theStack;
            Size = maxSize;
        }//End Constructor

        public static void Push(ArrayList theStack, int numToAdd)
        {
            theStack.Add(numToAdd);
        }//End Push Method

        public static void Pop(ArrayList theStack, int maxSize)
        {
            theStack.RemoveAt(maxSize);
        }//End Pop Method

        public static int Peek(ArrayList theStack, int maxSize)
        {
            return (int)theStack[maxSize];
        }//End Peek Method
    }//End Class
}//End Namespace