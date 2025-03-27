using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestion
{
    public class MinimumIndexOfValidSplit
    {
        // 2780 
    }
    public class Solution
    {
        public int MinimumIndex(IList<int> nums)
        {
            int idx = 0, MinIdx = -1;
            int DominantElementCnt = 0;
            int NonDominantElementCnt = 0;
            int dominantElement = -1, cnt = 0;

            foreach (int i in nums) {
                if (i != dominantElement) 
                {
                    if(cnt > 0 ) cnt--;
                    else
                    {
                        cnt++;
                        dominantElement = i;
                    }
                }
                else cnt++;
            }


            foreach (int i in nums) {

                _= (i == dominantElement) ?
                    DominantElementCnt++ : NonDominantElementCnt++;
                if (DominantElementCnt > NonDominantElementCnt && MinIdx == -1) 
                    MinIdx = idx;
                idx++;
            }
            if (DominantElementCnt - NonDominantElementCnt > 1) 
                return MinIdx;
            return -1;
        }
    }
}
