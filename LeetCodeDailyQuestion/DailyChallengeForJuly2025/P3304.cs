namespace LeetCodeDailyQuestion.DailyChallengeForJuly2025
{
    // 03-07-2025
    // By Yousry Essam
    // 3304. Find the K-th Character in String Game I
    internal class P3304
    {
        public char KthCharacter(int k)
        {
            int ans = 0;
            int t;
            while (k != 1)
            {
                t = (int)Math.Log(k, 2);
                if ((1 << t) == k)
                {
                    t--;
                }
                k = k - (1 << t);
                ans++;
            }
            return (char)('a' + ans);
        }
    }
}
