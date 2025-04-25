using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2845
    {
        // 2845. Count of Interesting Subarrays
        public long CountInterestingSubarrays(IList<int> nums, int modulo, int k)
        {
            var cnt = new Dictionary<int, int> { [0] = 1 };
            long res = 0;
            int prefix = 0;
            foreach (var num in nums)
            {
                if (num % modulo == k) prefix++;
                int target = (prefix - k + modulo) % modulo;
                if (cnt.TryGetValue(target, out int val)) res += val;
                cnt[prefix % modulo] = cnt.GetValueOrDefault(prefix % modulo, 0) + 1;
            }
            return res;
        }
    }
}
