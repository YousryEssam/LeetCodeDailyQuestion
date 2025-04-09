using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class P3375
    {
        // 3375. Minimum Operations to Make Array Values Equal to K
        public int MinOperations(int[] nums, int k)
        {
            Array.Sort(nums);
            int res = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] < k)
                {
                    return -1;
                }
                else if (nums[i] > k) {
                    if (i == 0 || nums[i] != nums[i - 1]) { 
                        res++;
                    }

                }
            }
            return res;
        }
    }
}
