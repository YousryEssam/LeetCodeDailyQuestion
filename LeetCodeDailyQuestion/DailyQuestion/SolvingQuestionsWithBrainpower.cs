using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestion
{
    class SolvingQuestionsWithBrainpower
    {
        // 2140. Solving Questions With Brainpower
        long[]? dp;
        int[][]? data;
        private long DpSolutoin(int idx)
        {
            if (idx >= dp.Length)
            {
                return 0;
            }
            if (dp[idx] != -1) { return dp[idx]; }
            dp[idx] = Math.Max(DpSolutoin(idx + 1), DpSolutoin(idx + 1 + data[idx][1]) + data[idx][0]);
            return dp[idx];

        }
        public long MostPoints(int[][] questions)
        {
            dp = new long[questions.Length];
            data = questions;
            for (int i = 0; i < dp.Length; i++) dp[i] = -1;
            return DpSolutoin(0);
        }
    }
}
