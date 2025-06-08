namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P386
    {
        // 08-06-2025
        // 386. Lexicographical Numbers
        public IList<int> LexicalOrder(int n)
        {
            List<int> result = new List<int>();
            int curr = 1;
            for (int i = 0; i < n; i++)
            {
                result.Add(curr);
                if (curr * 10 <= n)
                {
                    curr *= 10;
                }
                else
                {
                    while (curr % 10 == 9 || curr >= n)
                    {
                        curr /= 10;
                    }
                    curr++;
                }
            }
            return result;
        }
    }
}
