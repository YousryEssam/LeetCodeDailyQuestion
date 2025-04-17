using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.MiscellaneousProblems
{
    internal class P2006
    {
        // 2006. Count Number of Pairs With Absolute Difference K
        public int CountKDifference(int[] nums, int k)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
