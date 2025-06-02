namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P135
    {
        // 02-06-2025
        // 135. Candy
        public int Candy(int[] ratings)
        {
            int n = ratings.Length;
            int[] candies = new int[n];
            Array.Fill(candies, 1);

            // Left to right
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            // Right to left
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            return candies.Sum();
        }
    }
}
