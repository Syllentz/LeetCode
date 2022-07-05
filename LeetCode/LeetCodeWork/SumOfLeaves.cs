using LeetCode.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeWork
{
    public class SumOfLeaves
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int result = 0;
            TreeNode node = new TreeNode();
            if (root == null)
            {
                return 0;
            }
            if (root.left != null)
            {
                node = root.left;
                if (node.left == null && node.right == null)
                {
                    //return node.val;
                    result = node.val +result;
                }
                else
                {
                    result = SumOfLeftLeaves(node) + result;
                }                
            }
            if (root.right != null)
            {
                node = root.right;
                if (node.left != null || node.right != null)
                {
                   result = SumOfLeftLeaves(node) + result;
                }                
            }
            return result;
        }        
    }
}
