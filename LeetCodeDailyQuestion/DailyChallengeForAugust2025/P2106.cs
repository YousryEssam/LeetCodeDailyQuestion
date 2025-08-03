namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P2106
    {
        // 02-08-2025
        // By Yousry Essam
        // 2106. Maximum Fruits Harvested After at Most K Steps

        public int MaxTotalFruits(int[][] fruits, int startPos, int k)
        {
            int n = fruits.Length;
            int max = 0, sum = 0;
            int left = 0;

            for (int right = 0; right < n; right++)
            {
                sum += fruits[right][1];

                while (left <= right && !CanReach(fruits, left, right, startPos, k))
                {
                    sum -= fruits[left][1];
                    left++;
                }

                max = Math.Max(max, sum);
            }

            return max;
        }
        private bool CanReach(int[][] fruits, int left, int right, int startPos, int k)
        {
            int leftPos = fruits[left][0];
            int rightPos = fruits[right][0];
            int goLeftFirst = Math.Abs(startPos - leftPos) + (rightPos - leftPos);

            int goRightFirst = Math.Abs(startPos - rightPos) + (rightPos - leftPos);

            return Math.Min(goLeftFirst, goRightFirst) <= k;
        }
    }
}
