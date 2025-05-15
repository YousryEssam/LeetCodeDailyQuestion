using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P2900
    {
        // 2900. Longest Unequal Adjacent Groups Subsequence I
        public IList<string> GetLongestSubsequence(string[] words, int[] groups)
        {
            IList<string> result = new List<string>();
            int n = words.Length;
            int last = 1 - groups[0];
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || last != groups[i])
                {
                    result.Add(words[i]);
                    last = groups[i];
                }
            }
            return result;
        }
    }
}
