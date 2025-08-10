namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P231
    {
        // 231. Power of Two
        public bool IsPowerOfTwo(int n)
        {
            if (n == 0) return false;
            while (n != 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    break;
            }

            return n == 1;
        }
    }
}
