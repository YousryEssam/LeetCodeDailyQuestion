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

        //2240. Number of Ways to Buy Pens and Pencils 
        public long WaysToBuyPensPencils(int total, int cost1, int cost2)
        {
            long answer = 0;
            long curSum = 0;
            if (cost1 < cost2)
                (cost1, cost2) = (cost2, cost1);
            while (curSum <= total)
            {
                long temp = 1 + ((total - curSum) / cost2);
                answer += temp;
                curSum += cost1;
            }
            return answer;
        }
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
