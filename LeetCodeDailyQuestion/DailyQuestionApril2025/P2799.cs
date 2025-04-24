using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2799
    {
        // 2799. Count Complete Subarrays in an Array
        public int CountCompleteSubarrays(int[] nums)
        {
            int counter = 0;
            int numberOfDistinct = 0;
            
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            Dictionary<int, int> CurntSubArr = new Dictionary<int, int>();
            foreach(var i in nums) 
            {
                if (!keyValues.ContainsKey(i))
                {
                    numberOfDistinct++;
                    keyValues.Add(i, 1);
                }
                else
                {
                    keyValues[i]++;
                }
            }
            int end = 0, curntNumberOfDistinct = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                while (curntNumberOfDistinct < numberOfDistinct && end < nums.Length)
                {
                    if (CurntSubArr.ContainsKey(nums[end]) == false)
                    {
                        curntNumberOfDistinct++;
                        CurntSubArr.Add(nums[end], 1);
                    }
                    else
                    {
                        CurntSubArr[nums[end]]++;
                        if(CurntSubArr[nums[end]] == 1)
                        {
                            curntNumberOfDistinct++;
                        }
                    }
                    end++;
                }
                if(curntNumberOfDistinct == numberOfDistinct)
                {
                    counter += (nums.Length - end + 1);
                }
                CurntSubArr[nums[i]]--;
                if(CurntSubArr[nums[i]] == 0)
                {
                    curntNumberOfDistinct--;
                }
            }
            return counter;
        }
    }
}
