using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.MiscellaneousProblems
{
    internal class P2824
    {
        // 2824. Count Pairs Whose Sum is Less than Target
        public int CountPairs(IList<int> nums, int target)
        {
            nums = nums.OrderBy(x => x).ToList();
            int count = 0; 
            int left = 0; 
            int right = nums.Count - 1; 
            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                { 
                    count += right - left; 
                    left++; 
                }
                else
                { 
                    right--;
                }
            }
            return count;
        }
    }
}
