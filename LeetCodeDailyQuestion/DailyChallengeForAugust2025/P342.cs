namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P342
    {
        // 342. Power of Four
        public bool IsPowerOfFour(int n)
        {
            if (n <= 0) return false;
            while (n % 4 == 0)
            {
                n /= 4;
            }
            return n == 1;
        }
    }
}
