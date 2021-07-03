/*20.12 (Generic Classes TreeNode and Tree) Convert classes TreeNode and Tree from Fig. 19.20 into generic classes. To insert an object in a Tree, the object must be compared to the objects in
        existing TreeNodes. For this reason, classes TreeNode and Tree should specify IComparable<T> as the interface constraint of each class’s type parameter. 
        After modifying classes TreeNode and Tree, write a test app that creates three Tree objects—one that stores ints, one that stores doubles and one that stores strings.
        Insert 10 values into each tree. Then output the preorder, inorder and postorder traversals for each Tree.*/
using System;

namespace BinaryTreeLibrary
{
    // class TreeNode declaration
    class TreeNode<T> where T : IComparable<T>
    {
        // automatic property LeftNode
        public TreeNode<T> LeftNode { get; set; }

        // automatic property Data
        public T Data { get; private set; }

        // automatic property RightNode
        public TreeNode<T> RightNode { get; set; }

        // initialize Data and make this a leaf node
        public TreeNode(T nodeData)
        {
            Data = nodeData;
            RightNode = null;
            LeftNode = null;
        }

        // insert TreeNode into Tree that contains nodes;
        // ignore duplicate values
        public void Insert(T insertValue)

        {
            if (insertValue.CompareTo(Data) < 0) // insert in left subtree
            {
                // insert new TreeNode
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode<T>(insertValue);
                }
                else // continue traversing left subtree
                {
                    LeftNode.Insert(insertValue);
                }
            }
            else if (insertValue.CompareTo(Data) > 0) // insert in right subtree
            {
                // insert new TreeNode
                if (RightNode == null)
                {
                    RightNode = new TreeNode<T>(insertValue);
                }
                else // continue traversing right subtree
                {
                    RightNode.Insert(insertValue);
                }
            }
        }
    }

    // class Tree declaration
    public class Tree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;
        public Tree()
        {
            root = null;
        }

        // Insert a new node in the binary search tree.
        // If the root node is null, create the root node here.
        // Otherwise, call the insert method of class TreeNode.
        public void InsertNode(T insertValue)
        {
            if (root == null)
            {
                root = new TreeNode<T>(insertValue);
            }
            else
            {
                root.Insert(insertValue);
            }
        }

        // begin preorder traversal
        public void PreorderTraversal()
        {
            PreorderHelper(root);
        }

        // recursive method to perform preorder traversal
        private void PreorderHelper(TreeNode<T> node)
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
            InorderHelper(root);
        }

        // recursive method to perform inorder traversal
        private void InorderHelper(TreeNode<T> node)
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
            PostorderHelper(root);
        }

        // recursive method to perform postorder traversal
        private void PostorderHelper(TreeNode<T> node)
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
    }

    class TestApp
    {
        public static void Main(string[] args)
        {
            Tree<int> intTree = new Tree<int>();
            Tree<double> doubleTree = new Tree<double>();
            Tree<string> stringTree = new Tree<string>();

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            double[] doubleArray = { 1.11, 2.22, 3.33, 4.44, 5.55, 6.66, 7.77, 8.88, 9.99, 0.11 };
            string[] stringArray = { "str1", "str2", "str3", "str4", "str5", "str6", "str7", "str8", "str9", "str0" };

            Console.WriteLine("Int array contain: \n");
            foreach (var item in intArray)
            {
                Console.Write("{0} ", item);
                intTree.InsertNode(item);
            }

            // perform preorder traversal of tree
            Console.WriteLine("\n\nPreorder traversal");
            intTree.PreorderTraversal();
            // perform inorder traversal of tree
            Console.WriteLine("\n\nInorder traversal");
            intTree.InorderTraversal();
            // perform postorder traversal of tree
            Console.WriteLine("\n\nPostorder traversal");
            intTree.PostorderTraversal();
            Console.WriteLine();

            Console.WriteLine("Double array contain: \n");
            foreach (var item in doubleArray)
            {
                Console.Write("{0} ", item);
                doubleTree.InsertNode(item);
            }

            // perform preorder traversal of tree
            Console.WriteLine("\n\nPreorder traversal");
            doubleTree.PreorderTraversal();
            // perform inorder traversal of tree
            Console.WriteLine("\n\nInorder traversal");
            doubleTree.InorderTraversal();
            // perform postorder traversal of tree
            Console.WriteLine("\n\nPostorder traversal");
            doubleTree.PostorderTraversal();
            Console.WriteLine();

            Console.WriteLine(); Console.WriteLine("String array contain: \n");
            foreach (var item in stringArray)
            {
                Console.Write("{0} ", item);
                stringTree.InsertNode(item);
            }

            // perform preorder traversal of tree
            Console.WriteLine("\n\nPreorder traversal");
            stringTree.PreorderTraversal();
            // perform inorder traversal of tree
            Console.WriteLine("\n\nInorder traversal");
            stringTree.InorderTraversal();
            // perform postorder traversal of tree
            Console.WriteLine("\n\nPostorder traversal");
            stringTree.PostorderTraversal();

            Console.ReadLine();
        }
    }
}


