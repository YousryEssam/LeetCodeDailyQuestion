using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class MaximumValueOfAnOrderedTripletII
    {
        //2874. Maximum Value of an Ordered Triplet II 
        public long MaximumTripletValue(int[] nums)
        {
            long answer = 0;
            int Length = nums.Length;

            // Prefix max array to store the maximum value seen so far from the left
            int[] PrefixMax = new int[Length];
            PrefixMax[0] = nums[0];
            for (int i = 1; i < Length; i++)
            {
                PrefixMax[i] = Math.Max(PrefixMax[i - 1], nums[i]);
            }

            // Suffix max array to store the maximum value seen so far from the right
            int[] SuffixMax = new int[Length];
            SuffixMax[Length - 1] = nums[Length - 1];
            for (int i = Length - 2; i >= 0; i--)
            {
                SuffixMax[i] = Math.Max(SuffixMax[i + 1], nums[i]);
            }

            // Iterate over possible middle values
            for (int j = 1; j < Length - 1; j++)
            {
                int maxLeft = PrefixMax[j - 1];  // Maximum element to the left of j
                int maxRight = SuffixMax[j + 1]; // Maximum element to the right of j

                if (maxLeft > nums[j] && maxRight > 0)
                {
                    answer = Math.Max(answer, (long)(maxLeft - nums[j]) * maxRight);
                }
            }

            return answer;
        }
    }
}
