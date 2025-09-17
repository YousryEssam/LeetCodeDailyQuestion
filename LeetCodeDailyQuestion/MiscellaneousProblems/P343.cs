namespace LeetCodeDailyQuestion.MiscellaneousProblems
{
    internal class P343
    {
        int N;
        int[][] dp;
        int DpSolve(int n, int k)
        {
            if (n == 0) return 1;
            if (dp[n][k] != -1) return dp[n][k];
            int ans = int.MinValue;
            for (int i = 1; i <= Math.Min(n, N - 1); i++)
            {
                ans = Math.Max(ans, i * DpSolve(n - i, i));
            }
            return dp[n][k] = ans;
        }
        public int IntegerBreak(int n)
        {
            N = n;
            dp = new int[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                dp[i] = new int[n + 1];
                for (int j = 0; j <= n; j++)
                {
                    dp[i][j] = -1;
                }
            }
            return DpSolve(n, 0);
        }
    }
}