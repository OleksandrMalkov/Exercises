/*19.8 (Level-Order Binary Tree-Traversal) The program of Fig. 19.21 illustrated three recursive methods of traversing a binary tree—inorder, preorder,
       and postorder traversals. This exercise presents the level-order traversal of a binary tree, in which the node values are displayed level by level,
       starting at the root-node level. The nodes on each level are displayed from left to right. The level order traversal is not a recursive algorithm.
       It uses a queue object to control the output of the nodes.
       The algorithm is as follows:
        a) Insert the root node in the queue.
        b) While there are nodes left in the queue, do the following:
               Get the next node in the queue.
               Display the node’s value.
               If the reference to the left child of the node is not null:
                    Insert the left child node in the queue.
               If the reference to the right child of the node is not null:
                    Insert the right child node in the queue.
      Write method LevelOrderTraversal to perform a level-order traversal of a binary-tree object.
    Modify the program of Fig. 19.21 to use this method. [Note: You also will need to use the queueprocessing methods of Fig. 19.16 in this program.]*/
using System;

// class TreeTest declaration
namespace BinaryTreeLibrary
{
    class TreeTestModify
    {
        // test class Tree
        static void Main()
        {
            Tree tree = new Tree();
            int insertValue;

            Console.WriteLine("Inserting values: ");
            Random random = new Random();

            // insert 10 random integers from 0-99 in tree 
            for (var i = 1; i <= 10; i++)
            {
                insertValue = random.Next(100);
                Console.Write($"{insertValue} ");

                tree.InsertNode(insertValue);
            }

            // perform preorder traversal of tree
            Console.WriteLine("\n\nPreorder traversal");
            tree.PreorderTraversal();

            // perform inorder traversal of tree
            Console.WriteLine("\n\nInorder traversal");
            tree.InorderTraversal();

            // perform postorder traversal of tree
            Console.WriteLine("\n\nPostorder traversal");
            tree.PostorderTraversal();
            Console.WriteLine();

            // perform levelorder traversal of tree
            Console.WriteLine("\n\nLevel Order traversal");
            tree.LevelOrderTraversal();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}