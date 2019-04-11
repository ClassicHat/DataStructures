/****[ READ ME ]***************
 * Author: Dylan Buehler
 * Date: 4/11/2019
 * Filename: BinaryTreeNode.cs
 * Copyright: DilCoInc 2019
 ******************************/
namespace BinaryTree
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
    }//End Class LLNode
}//End Namespace