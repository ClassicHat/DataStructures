using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        //Private Class Fields
        private BinaryTreeNode root;
        private BinaryTreeNode current;

        //Public Class Properties
        public BinaryTreeNode Root { get => root; set => root = value; }
        public BinaryTreeNode Current { get => current; set => current = value; }

        //Public Constructor
        public BinaryTree()
        {
            Root = null;
            Current = null;
        }//End BinaryTree Constructor

        public void Insert(char theLetter)
        {
            //Create the node with the provided value
            BinaryTreeNode theNode = new BinaryTreeNode();
            theNode.Letter = theLetter;

            //If there is not a root node make one
            if(Root == null)
            {
                Root = theNode;
            }
            else
            {
                Root.AddNode(theNode);
            }
        }//End Insert Method

        public void Traverse()
        {
            Root.Visit();
        }

        public void Search(char theLetter)
        {
            BinaryTreeNode found = Root.Search(theLetter);

            if(found != null)
            {
                Console.WriteLine("Found: " + found.Letter);
            }
            else
            {
                Console.WriteLine("Not Found In the Tree");
            }
        }

    }//End BinaryTree Class
}//End Namespace