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

        public void Helper(TreeNode root, List<int> res)
        {
            if (root != null)
            {
                Helper(root.left, res);
                res.Add(root.val);
                Helper(root.right, res);
            }
        }
    }
    public class TreeNode
    {
      public int val;
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


        // Adding new values to tree = via insert
        /*public void Insert(int newVal)
        {
            if (newVal <= val )
            {
                // If there's nothing on the left child node... 
                if (left == null)
                {
                    // Create a new node 
                    left = new TreeNode(newVal);
                }
                else
                {
                    // Keep checking (recursion) 
                    left.Insert(newVal);
                }

            }
            else
            {
                if (right == null)
                {
                    right = new TreeNode(newVal);
                }
                else
                {
                    right.Insert(newVal);
                }
            }
        }*/


        // Goal = Insert new value into node tree where...
            // Left side = lower than parent
            // Right side = higher than parent
        public void Insert(int newVal)
        {
            if (newVal <= val)
            {
                if (left != null)
                {
                    // Keep going
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



    }

}
