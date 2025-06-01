namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P2929
    {

        // 01-06-2025
        // 2929. Distribute Candies Among Children II
        public long DistributeCandies(int n, int limit)
        {
            long answer = 0;
            if (n > limit * 3)
            {
                return answer;
            }
            for (int i = 0; i <= Math.Min( n , limit); i++)
            {
                long remin = n - i;
                if (remin <= limit * 2)
                {
                    long minVlaue = 0;
                    long maxVlaue = remin;
                    if (maxVlaue > limit)
                    {
                        minVlaue = maxVlaue - limit;
                        maxVlaue = limit;
                    }
                    answer += (maxVlaue - minVlaue + 1);
                }
            }
            return answer;
        }
    }
}