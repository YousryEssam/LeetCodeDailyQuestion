using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class LargestDivisibleSubsetClass
    {
        // 368. Largest Divisible Subset
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            Array.Sort(nums);
            int size = nums.Length;
            IList<int> result = new List<int>();

            List<int> dp = Enumerable.Repeat(1, size).ToList();
            List<int> prev = Enumerable.Repeat(-1, size).ToList();

            int MaxValue = 0;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] % nums[j] == 0 && dp[i] < dp[j] + 1)
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }
                if (dp[i] > dp[MaxValue]) MaxValue = i;
            }

            for (int i = MaxValue; i >= 0; i = prev[i])
            {
                result.Add(nums[i]);
                if (prev[i] == -1) break; // Stop when there's no previous
            }

            return result;
        }

    }
}
