using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class MaximumValueOfAnOrderedTripletI
    {
        // 2873. Maximum Value of an Ordered Triplet I
        public long MaximumTripletValue(int[] nums)
        {
            long answer = 0;
            int size = nums.Length;

            // NextMax stores the maximum element to the right of each index
            int[] nextMax = new int[size + 1];
            int maxValue = 0;

            for (int i = size - 1; i >= 0; i--)
            {
                maxValue = Math.Max(nums[i], maxValue);
                nextMax[i] = maxValue;
            }

            // Iterate over possible (x, y, z) triplets
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size - 1; j++)
                {
                    long value = (long)(nums[i] - nums[j]) * nextMax[j + 1];
                    answer = Math.Max(answer, value);
                }
            }

            return answer;
        }
    }


}
