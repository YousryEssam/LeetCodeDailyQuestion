using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P1550
    {
        // 1550. Three Consecutive Odds
        // 11-5-2025
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] % 2 == 1 && arr[i + 1] % 2 == 1 && arr[i + 2] % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
