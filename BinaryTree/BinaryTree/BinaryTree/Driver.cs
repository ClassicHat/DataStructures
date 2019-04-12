/*************************************
 * Name: Dylan Buehler
 * Date: 4/12/2019
 * Filename: Binary Tree
 * Copyright: DilCoInc 2019
 *************************************/
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Create a Random Number Generator
            Random num = new Random();

            //Array of char letters
            char[] letters = new char[5] { 'A', 'B', 'C', 'D', 'E' };

            //Create the root node
            BinaryTreeNode rootNode = new BinaryTreeNode();

            //Holder for the previous node
            BinaryTreeNode prevNode = new BinaryTreeNode();

            for (int i = 0; i < 5; i++)
            {
                //Create a new node to add to the tree
                BinaryTreeNode theNode =  new BinaryTreeNode();

                //Get a random number
                int theNum = num.Next(0, 2);

                //Try adding to the left or right branch of the prev node
                if(theNum == 0)
                {
                    prevNode.Left = theNode;
                    theNode.Letter = letters[i];
                    WriteLine("New Node Added To The Left Branch");
                }
                else
                {
                    prevNode.Right = theNode;
                    theNode.Letter = letters[i];
                    WriteLine("New Node Added To The Right Branch");
                }

                prevNode = theNode;
            }//End For Loop

            //Readkey To Stop Program
            ReadKey();

        }//End Main Method
    }//End Class Driver
}//End Namespace