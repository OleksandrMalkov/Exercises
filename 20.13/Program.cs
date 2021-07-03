/*20.13 (Generic Method TestTree) Modify your test program from Exercise 20.12 to use generic method TestTree to test the three Tree objects. 
        The method should be called three times—once foreach Tree object.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
        static void TestTree<T>(string treeName, T[] inputArray, Tree<T> tree) where T : IComparable<T>
        {
            Console.WriteLine(
            "\n\n\nInserting the following values in the {0}", treeName);

            foreach (T element in inputArray)
            {
                Console.Write("{0} ", element);
                tree.InsertNode(element);
            }

            Console.WriteLine("\nPreorder traversal of {0}", treeName);
            tree.PreorderTraversal();

            Console.WriteLine("\nInorder traversal of {0}", treeName);
            tree.InorderTraversal();

            Console.WriteLine("\nPostorder traversal of {0}", treeName);
            tree.PostorderTraversal();
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Tree<int> intTree = new Tree<int>();
            Tree<double> doubleTree = new Tree<double>();
            Tree<string> stringTree = new Tree<string>();

            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            double[] doubleArray = { 1.11, 2.22, 3.33, 4.44, 5.55, 6.66, 7.77, 8.88, 9.99, 0.11 };
            string[] stringArray = { "str1", "str2", "str3", "str4", "str5", "str6", "str7", "str8", "str9", "str0" };

            TestTree("intTree", intArray, intTree);
            TestTree("doubleTree", doubleArray, doubleTree);
            TestTree("stringTree", stringArray, stringTree);

            Console.ReadLine();
        }
    }
}


