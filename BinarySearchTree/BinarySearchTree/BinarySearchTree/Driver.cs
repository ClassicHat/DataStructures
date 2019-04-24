using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Create a Tree
            BinaryTree theTree = new BinaryTree();

            //Arraylist full of letters
            char[] letters = new char[10] { 'J', 'F', 'D', 'A', 'G', 'C', 'H', 'B', 'I', 'E' };

            for(int i = 0; i < 10; i++)
            {
                theTree.Insert(letters[i]);
            }

            theTree.Traverse();

            theTree.Search('H');

            theTree.Search('Z');

            ReadKey();
        }
    }
}
