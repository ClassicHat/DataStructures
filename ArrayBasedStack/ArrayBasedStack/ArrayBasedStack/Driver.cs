using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedStack
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Create a Random Number Generator
            Random num = new Random();

            //Create an ArrayList
            ArrayList myStack = new ArrayList();

            //Create a Array stack instance
            ArrayStack theStack = new ArrayStack(myStack, 10);
            
            WriteLine("Try To Pop An Empty Stack");
            theStack.Pop();

            //Fill the stack
            WriteLine("\nFill The Stack With Values");
            for (int i = 0; i < theStack.Capacity; i++)
            {
                theStack.Push(num.Next(0, 10));
            }//End for loop

            //Print the stack for comparison
            PrintStack(theStack);
            
            //Try out the peek method
            WriteLine($"\nPeek Method Returned: {theStack.Peek().ToString()}");

            //Try to push past capacity
            WriteLine("\nTry To Push Over Capacity");
            theStack.Push(22);

            //Tryout the pop method
            WriteLine($"\nPop Method Removed: {theStack.Peek()} From The Stack");
            theStack.Pop();
            WriteLine($"\nPop Method Removed: {theStack.Peek()} From The Stack");
            theStack.Pop();

            //Print for comparison
            PrintStack(theStack);

            //Try to push again
            WriteLine("\nPushing Value '22' To The Stack");
            theStack.Push(22);

            //Try to push again
            WriteLine("\nPushing Value '33' To The Stack");
            theStack.Push(33);

            //Try to push again
            WriteLine("\nPushing Value '44' To The Stack");
            theStack.Push(44);

            //Print for comparison
            PrintStack(theStack);

            //Try out the peek method
            WriteLine($"\nPeek Method Returned: {theStack.Peek().ToString()}");

            //Readkey to stop the program
            ReadKey();
        }

        public static void PrintStack(ArrayStack theStack)
        {
            WriteLine("\nTop Of Stack");
            
            for (int j = theStack.Size - 1; j >= 0; j--)
            {
                WriteLine($"   | {theStack.MyStack[j].ToString()} |");
            }//End for loop
            WriteLine("Bottom Of Stack");
        }//End PrintStack Method
    }//End Class
}//End Namespace