using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class LowestCommonAncestorOfDeepestLeaves
    {

        //1123. Lowest Common Ancestor of Deepest Leaves
        private int maxDepth = 0;
        private TreeNode result = null;

        public TreeNode LcaDeepestLeaves(TreeNode root)
        {
            Helper(root, 0);
            return result;
        }

        public int Helper(TreeNode node, int level)
        {
            if (node == null)
            {
                return 0;
            }

            int left = Helper(node.left, level + 1);
            int right = Helper(node.right, level + 1);

            if (left == right && level + left >= maxDepth)
            {
                maxDepth = level + left;
                result = node;
            }

            return Math.Max(left, right) + 1;
        }
    }
}
