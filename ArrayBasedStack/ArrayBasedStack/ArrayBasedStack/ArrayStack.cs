using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedStack
{
    public class ArrayStack
    {
        private int capacity;
        private int size;
        private ArrayList myStack;

        public int Capacity { get => capacity; set => capacity = value; }
        public int Size { get => size; set => size = value; }
        public ArrayList MyStack { get => myStack; set => myStack = value; }

        //Default Constructor
        public ArrayStack(ArrayList theStack, int maxCap)
        {
            MyStack = theStack;
            Size = 0;
            Capacity = maxCap;
        }//End Constructor

        public void Push(int numToAdd)
        {
            if(Size != Capacity)
            {
                //Adds a value to the stack
                MyStack.Add(numToAdd);

                //Add one to the Size
                Size++;
            }
            else
            {
                WriteLine($"Error - 'Push Method' - Capacity Reached! Value '{numToAdd.ToString()}' Not Added To The Stack");
            }//End if / else
        }//End Push Method

        public void Pop()
        {
            if(Size != 0)
            {
                //Remove the value that is on top
                MyStack.RemoveAt(Size - 1);

                //Remove one from the Size
                Size--;
            }
            else
            {
                WriteLine($"Error - 'Pop Method' - Stack Is Empty!");
            }//End Pop Method
        }//End Pop Method

        public int Peek()
        { 
            //Return the value of the top element
            return (int) MyStack[Size - 1];
        }//End Peek Method
    }//End Class
}//End Namespace