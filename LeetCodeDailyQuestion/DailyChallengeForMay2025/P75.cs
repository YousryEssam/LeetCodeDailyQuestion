using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P75
    {
        // 75. Sort Colors 
        // 17-5-2025
        public void SortColors(int[] nums)
        {
            int cnt0 = 0, cnt1 = 0;
            foreach (int i in nums) 
            {
                if(i==0) cnt0++;
                else if(i==1) cnt1++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if(cnt0 > 0)
                {
                    cnt0--;
                    nums[i] = 0;
                }
                else if(cnt1 > 0)
                {
                    cnt1--;
                    nums[i] = 1;
                }
                else
                {
                    nums[i] = 2;
                }
            }
        }
    }
}
