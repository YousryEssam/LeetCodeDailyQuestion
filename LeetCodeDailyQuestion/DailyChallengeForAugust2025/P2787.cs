namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P2787
    {
        // 2787. Ways to Express an Integer as Sum of Powers
        private const int MOD = 1000000007;
        private int[][] dp = null!;
        private int[] powerValues = null!;
        private int targetSum;
        private int DpCalculate(int idx, int lastValue)
        {
            if (idx == targetSum) return 1;
            if (idx > targetSum || powerValues[lastValue + 1] + idx > targetSum) return 0;

            ref int curState = ref dp[idx][lastValue];
            if (curState != -1) return curState;
            curState = 0;

            for (int i = lastValue + 1; i <= targetSum; i++)
            {
                int power = powerValues[i];
                if (idx + power > targetSum) break;

                curState = (curState + DpCalculate(idx + power, i)) % MOD;
            }
            return curState % MOD;
        }
        public int NumberOfWays(int n, int x)
        {
            targetSum = n;
            dp = new int[n + 1][];
            powerValues = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                dp[i] = new int[n + 1];
                powerValues[i] = (int)Math.Pow(i, x);
                for (int j = 0; j <= n; j++)
                {
                    dp[i][j] = -1;
                }
            }
            return DpCalculate(0, 0) % MOD;
        }
    }
}
