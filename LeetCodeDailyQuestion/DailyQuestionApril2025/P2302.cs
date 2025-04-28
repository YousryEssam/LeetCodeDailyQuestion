using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2302
    {
        // 2302. Count Subarrays With Score Less Than K
        long[] prefix;
        long value;
        private long SubarrayScore(int l , int r)
        {
            long len = r - l + 1;
            return (prefix[r] - prefix[l - 1]) * len;

        }
        private int ValidSubarrays(int idx)
        {
            int left = idx, right = prefix.Length - 2, mid;
            int answer = -1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                long score = SubarrayScore(idx, mid);
                if (score < value) {
                    answer = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            if (answer != -1)
            {
                return answer - idx + 1;
            }
            return 0;
        }
        public long CountSubarrays(int[] nums, long k)
        {
            long countSubarrays = 0;
            value = k;
            prefix = new long[nums.Length + 2];
            for (int i = 0; i < nums.Length; i++) {
                prefix[i + 1] = nums[i] + prefix[i];
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                countSubarrays += ValidSubarrays(i);
            }
            return countSubarrays;
        }

        // Best time performance 

        public long CountSubarrays2(int[] nums, long k)
        {
            long l = 0, r = 0, sum = 0, ans = 0;

            for (; r < nums.Length; r++)
            {
                sum += nums[r];

                while (sum * (r - l + 1) >= k)
                {
                    sum -= nums[l];
                    l++;
                }

                ans += r - l + 1;
            }

            return ans;
        }
    }
}
