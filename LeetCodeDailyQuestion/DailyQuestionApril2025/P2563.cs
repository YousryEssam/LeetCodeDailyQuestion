using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2563
    {
        // 2563. Count the Number of Fair Pairs
        public long CountFairPairs(int[] nums, int lower, int upper)
        {
            Array.Sort(nums);
            long Result = 0;
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int minIdx = LowerBound(nums, lower - nums[i]);
                minIdx = Math.Max(minIdx, i + 1);

                int maxIdx = LowerBound(nums, upper - nums[i] + 1);

                if (maxIdx >= minIdx)
                    Result += maxIdx - minIdx;
            }

            return Result;
        }

        private int LowerBound(int[] nums, int value)
        {
            int left = 0, right = nums.Length;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < value)
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
    }
}
