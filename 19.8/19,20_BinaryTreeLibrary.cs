// Fig. 19.20: BinaryTreeLibrary.cs
// Declaration of class TreeNode and class Tree.
using System;

namespace BinaryTreeLibrary
{
    // class TreeNode declaration
    class TreeNode
    {
        // automatic property LeftNode
        public TreeNode LeftNode { get; set; }

        // automatic property Data
        public int Data { get; private set; }

        // automatic property RightNode
        public TreeNode RightNode { get; set; }

        // initialize Data and make this a leaf node
        public TreeNode(int nodeData)
        {
            Data = nodeData;
        }

        // insert TreeNode into Tree that contains nodes;
        // ignore duplicate values
        public void Insert(int insertValue)
        {
            if (insertValue < Data) // insert in left subtree
            {
                // insert new TreeNode
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(insertValue);
                }
                else // continue traversing left subtree
                {
                    LeftNode.Insert(insertValue);
                }
            }
            else if (insertValue > Data) // insert in right subtree
            {
                // insert new TreeNode
                if (RightNode == null)
                {
                    RightNode = new TreeNode(insertValue);
                }
                else // continue traversing right subtree
                {
                    RightNode.Insert(insertValue);
                }
            }
        }
        public int Height(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                /* compute height of each subtree */
                int lHeight = Height(node.LeftNode);
                int rHeight = Height(node.RightNode);

                /* use the larger one */
                if (lHeight > rHeight)
                {
                    return (lHeight + 1);
                }
                else
                {
                    return (rHeight + 1);
                }
            }
        }

    }

    // class Tree declaration
    public class Tree
    {
        private TreeNode node;

        // Insert a new node in the binary search tree.
        // If the root node is null, create the root node here.
        // Otherwise, call the insert method of class TreeNode.
        public void InsertNode(int insertValue)
        {
            if (node == null)
            {
                node = new TreeNode(insertValue);
            }
            else
            {
                node.Insert(insertValue);
            }
        }

        // begin preorder traversal
        public void PreorderTraversal()
        {
            PreorderHelper(node);
        }

        // recursive method to perform preorder traversal
        private void PreorderHelper(TreeNode node)
        {
            if (node != null)
            {
                // output node Data              
                Console.Write($"{node.Data} ");

                // traverse left subtree        
                PreorderHelper(node.LeftNode);

                // traverse right subtree        
                PreorderHelper(node.RightNode);
            }
        }

        // begin inorder traversal
        public void InorderTraversal()
        {
            InorderHelper(node);
        }

        // recursive method to perform inorder traversal
        private void InorderHelper(TreeNode node)
        {
            if (node != null)
            {
                // traverse left subtree       
                InorderHelper(node.LeftNode);

                // output node data              
                Console.Write($"{node.Data} ");

                // traverse right subtree       
                InorderHelper(node.RightNode);
            }
        }

        // begin postorder traversal
        public void PostorderTraversal()
        {
            PostorderHelper(node);
        }

        // recursive method to perform postorder traversal
        private void PostorderHelper(TreeNode node)
        {
            if (node != null)
            {
                // traverse left subtree         
                PostorderHelper(node.LeftNode);

                // traverse right subtree         
                PostorderHelper(node.RightNode);

                // output node Data              
                Console.Write($"{node.Data} ");
            }
        }
        
        //Print nodes at the current level 
        private void CurrentLevel(TreeNode root, int level)
        {
            if (root == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.Write(root.Data + " ");
            }
            else if (level > 1)
            {
                CurrentLevel(root.LeftNode, level - 1);
                CurrentLevel(root.RightNode, level - 1);
            }
        }
        public void LevelOrderTraversal()
        {
            LevelOrderHelper(node);
        }
        private void LevelOrderHelper(TreeNode root)
        {
            int h = root.Height(node);
            int i;
            for (i = 1; i <= h; i++)
            {
                CurrentLevel(node, i);
            }
        }
    }
}



/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/