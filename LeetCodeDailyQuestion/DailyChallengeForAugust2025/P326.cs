namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P326
    {
        // 326. Power of Three
        public bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            while (n != 1)
            {
                if (n % 3 != 0) return false;
                n /= 3;
            }
            return n == 1;
        }
    }
}
