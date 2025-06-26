namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P2311
    {
        // 26-06-2025
        // By Yousry Essam
        // 2311. Longest Binary Subsequence Less Than or Equal to K

        public int LongestSubsequence(string s, int k)
        {
            int n = 0;
            for (int i = s.Length; i-- > 0;)
            {
                if (k > 0)
                {
                    k -= s[i] == '1' ? 1 : 0;
                    k >>= 1;
                    ++n;
                }
                else if (s[i] == '0') ++n;
            }
            return n;
        }
    }
}
