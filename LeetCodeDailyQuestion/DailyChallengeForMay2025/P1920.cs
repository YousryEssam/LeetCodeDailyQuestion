using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P1920
    {
        // 1920. Build Array from Permutation
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) 
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }
    }
}
