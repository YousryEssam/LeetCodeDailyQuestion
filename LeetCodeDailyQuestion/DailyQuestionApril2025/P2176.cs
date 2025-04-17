using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2176
    {
        // 2176. Count Equal and Divisible Pairs in an Array
        public int CountPairs(int[] nums, int k)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i ++)
            {
                for(int  j = i + 1; j< nums.Length; j++)
                {
                    if(nums[j] == nums[i] && i*j % k ==0 )
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
