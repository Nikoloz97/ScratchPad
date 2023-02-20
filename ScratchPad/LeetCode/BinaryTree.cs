using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPad.LeetCode
{
    //https://leetcode.com/problems/binary-tree-inorder-traversal/description/
    //What binary trees are: https://www.youtube.com/watch?v=oSWTXtMglKE&ab_channel=HackerRank  (Inorder traversal = 3:15) 
    // Relative to parent...
        // Left child node = lower
        // Right child node = higher
   
    public class BinaryTree
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Helper(root, res);
            return res;

        }

        public void Helper(TreeNode root, List<int> result)
        {
            if (root != null)
            {
                Helper(root.left, result);
                result.Add(root.val);
                Helper(root.right, result);
            }
        }

    }
    public class TreeNode
    {
      // val = parent node
      public int val;
        // "Embedded class fields" (I made that term up) 
      public TreeNode left;
      public TreeNode right;

        // Constructor 1
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        // Constructor 2
        public TreeNode(int val)
        {
            this.val = val; 
        }


        // Insert new value into node tree where...
            // Left side = lower than parent
            // Right side = higher than parent
        public void Insert(int newVal)
        {
            if (newVal <= val)
            {
                if (left != null)
                {
                    // Keep checking on left
                    left.Insert(newVal);
                }
                else
                {
                    left = new TreeNode(newVal);
                }
            }
            else
            {
                if (right != null)
                {
                    right.Insert(newVal);
                }
                else
                {
                    right = new TreeNode(newVal);
                }
            }
        }

        // Check if node tree contains a value
        public Boolean Contains(int newVal)
        {
            // val = parent node
            if (newVal == val)
            {
                return true;
            }
            else if (newVal < val)
            {
                if (left == null)
                {
                    return false;
                }
                // Progress to left child node. Do the same thing
                else
                {
                    left.Contains(newVal);
                }

            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    // Progress to right child node. Do the same thing
                    right.Contains(newVal);
                }
            }

            // Just to satisfy function (not all codes return a value) 
            return true;

        }

        // Prints words InOrder traversal (starting from very end of left branch: left node, parent, right node)
        // Watch video at 8:10
        // Paste these values into program.cs: 
        // TreeNode tree = new TreeNode(10);
        //tree.Insert(5);
        //tree.Insert(8);
        //tree.Insert(15);
        //tree.PrintInOrderTraversal();
        public void PrintInOrderTraversal()
        {
            if (left != null)
            {
                left.PrintInOrderTraversal();
            }
            Console.WriteLine(val);

            if (right != null)
            {
                right.PrintInOrderTraversal();
            }

        }


        public TreeNode InvertTree (TreeNode root)
        {
            if (root == null) { return root; }
            InvertTree(root.left);
            InvertTree(root.right);
            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            return root;
        }












    }

}
