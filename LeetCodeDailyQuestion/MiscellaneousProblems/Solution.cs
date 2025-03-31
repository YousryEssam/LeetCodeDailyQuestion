using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.MiscellaneousProblems
{
    // This Class have Miscellaneous problems 
    class Solution
    {
        // 2405. Optimal Partition of String
        public int PartitionString(string s)
        {
            int ans = 1;
            int[] frq = new int[26];
            for(int i =0; i < s.Length; i ++)
            {
                if(frq[s[i] - 'a'] > 0) 
                {
                    ans++;
                    for (int j = 0; j < 26; j++)
                    {
                        frq[j] = 0;
                    }
                }
                frq[s[i] - 'a']++;
            }
            return ans;
        }
    }
}
