/****[ READ ME ]***************
 * Author: Dylan Buehler
 * Date: 4/20/2019
 * Filename: BinaryTreeNode.cs
 * Copyright: DilCoInc 2019
 ******************************/
using System;
using static System.Console;

namespace BinarySearchTree
{
    class BinaryTreeNode
    {
        //Private Fields
        private char letter;
        private BinaryTreeNode left;
        private BinaryTreeNode right;
        
        //Public Properties
        public char Letter { get => letter; set => letter = value; }
        public BinaryTreeNode Left { get => left; set => left = value; }
        public BinaryTreeNode Right { get => right; set => right = value; }

        //Default Constructor
        public BinaryTreeNode() {
            Letter = '\0';
            Left = null;
            Right = null;
        }//End BinaryTreeNode Constructor

        public void AddNode(BinaryTreeNode theNode)
        {
            if (theNode.Letter < this.Letter)
            {
                if (this.Left == null)
                {
                    this.Left = theNode;
                }
                else
                {
                    this.Left.AddNode(theNode);
                }//End if / else
            }
            else
            {
                if(this.Right == null)
                {
                    this.Right = theNode;
                }
                else
                {
                    this.Right.AddNode(theNode);
                }//End if / else
            }//End if / else
        }//End AddNode

        public void Visit()
        {
            if(this.Left != null)
            {
                this.Left.Visit();
            }//End if

            WriteLine(this.Letter);

            if(this.Right != null)
            {
                this.Right.Visit();
            }//End if
        }//End Visit

        public BinaryTreeNode Search(char theLetter)
        {
            if(this.Letter == theLetter)
            {
                return this;
            }
            else if(theLetter < this.Letter && this.Left != null)
            {
                return this.Left.Search(theLetter);
            }
            else if (theLetter > this.Letter && this.Right != null)
            {
                return this.Right.Search(theLetter);
            }

            return null;
        }//End Search Method
    }//End Class LLNode
}//End Namespace