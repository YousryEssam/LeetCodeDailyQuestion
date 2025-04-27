using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P3392
    {
        // 3392. Count Subarrays of Length Three With a Condition
        public int CountSubarrays(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length -2; i++) {
                if ((nums[i] + nums[i+2]) * 2 == nums[i + 1])
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
