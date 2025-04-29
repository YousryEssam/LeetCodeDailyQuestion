using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2962
    {
        //2962. Count Subarrays Where Max Element Appears at Least K Times
        public long CountSubarrays(int[] nums, int k)
        {
            long counter = 0;
            int maxElement = 0 , len = nums.Length;
            foreach (int i in nums) 
            {
                if(i > maxElement)
                    maxElement = i;
            }
            int maxElementCnt = 0;
            int startIdx = 0;
            for (int i = 0; i < nums.Length; i ++)
            {
                if (nums[i] == maxElement)
                    maxElementCnt++;
                while (maxElementCnt >= k)
                {
                    counter += len - i;
                    if (nums[startIdx] == maxElement)
                        maxElementCnt--;
                    startIdx++;
                }
            }
            return counter;
        }
    }
}
