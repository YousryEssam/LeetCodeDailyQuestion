using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2537
    {
        // 2537. Count the Number of Good Subarrays
        public long CountGood(int[] nums, int k)
        {
            long result = 0;
            int size = nums.Length;
            Dictionary<int, int> frq = new Dictionary<int, int>();
            int left = 0, right = -1;
            long same = 0;

            for (left = 0; left < size; left++)
            {
                while (same < k && right + 1 < size)
                {
                    right++;
                    if (!frq.ContainsKey(nums[right]))
                        frq[nums[right]] = 0;

                    same += frq[nums[right]]; 
                    frq[nums[right]]++;  
                }

                if (same >= k)
                {
                    result += size - right;
                }

                frq[nums[left]]--;           
                same -= frq[nums[left]];   
            }

            return result;
        }

    }
}
