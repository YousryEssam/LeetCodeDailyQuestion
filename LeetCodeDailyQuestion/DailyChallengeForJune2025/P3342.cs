namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P3342
    {
        // 10-06-2025
        // 3442. Maximum Difference Between Even and Odd Frequency I
        public int MaxDifference(string s)
        {
            int oddCnt = 0;
            int evenCnt = 0;

            int[] frq = new int[26];
            foreach (var i in s) frq[i - 'a']++;

            for (int i = 0; i < 26; i++)
            {
                if (frq[i] % 2 == 0)
                {
                    if (evenCnt == 0) evenCnt = frq[i];
                    if (frq[i] < evenCnt && frq[i] != 0) evenCnt = frq[i];
                }
                else
                {
                    if (frq[i] > oddCnt) oddCnt = frq[i];
                }
            }

            return oddCnt - evenCnt;
        }
    }
}
