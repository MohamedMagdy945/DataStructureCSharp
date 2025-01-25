using System;
using System.Reflection;
namespace Datastructure.Datastructure
{
    class TreeNode
    {
        internal int value;
        internal TreeNode right;
        internal TreeNode left;
    }
    internal class BinarySearchTree
    {
        TreeNode root;
        private void AddNode(TreeNode root , TreeNode NewNode)
        {
            if (NewNode.value < root.value)
            {
                if (root.left == null)
                    root.left = NewNode;
                else 
                    AddNode(root.left, NewNode);
            }
            else
            {
                if (root.right == null)
                    root.right = NewNode;
                else
                    AddNode(root.right, NewNode);
            }

        }
        public void Add(int value)
        {
            TreeNode NewNode = new TreeNode();
            NewNode.value = value;
            if (isEmpty())
            {
                root = NewNode;
                return;
            }
            AddNode( root , NewNode);
        }
        public bool isEmpty()
        {
            if (root == null)
                return true;
            return false;
        }
        private void DisplayTreePreOrder(TreeNode root)
        {
            if (isEmpty()) {
                Console.WriteLine("Tree is empty");
                return;
            }
            Console.Write($"{root.value} ");
            if (root.left != null)
                DisplayTreePreOrder(root.left);
            if (root.right != null)
                DisplayTreePreOrder(root.right);
        }
        public void Display()
        {
            DisplayTreePreOrder(root);
            Console.WriteLine();
        }

    }
}
