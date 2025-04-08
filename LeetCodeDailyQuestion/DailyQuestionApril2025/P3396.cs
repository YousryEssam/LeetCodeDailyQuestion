using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class P3396
    {
        // 3396. Minimum Number of Operations to Make Elements in Array Distinct
        public int MinimumOperations(int[] nums)
        {
            int answer = -1;
            int[] frq = new int[101];
            for(int i = 0; i < 101; i ++)
            {
                frq[i] = -1;
            }
            for(int i = 0; i < nums.Length; i ++)
            {
                if (frq[nums[i]] != -1)
                {
                    answer = Math.Max(answer, frq[nums[i]]);
                }
                frq[nums[i]] = i;
            }
            if(answer < 0)
            {
                return 0;
            }
            return (int)Math.Ceiling((answer+1) / 3.0);
        }
    }
}
