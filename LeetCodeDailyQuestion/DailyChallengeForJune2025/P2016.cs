namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P2016
    {
        // 16-06-2025
        // 2016. Maximum Difference Between Increasing Elements 
        public int MaximumDifference(int[] nums)
        {
            int[] suffixMax = new int[nums.Length];
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                if (i == nums.Length - 1)
                {
                    suffixMax[i] = nums[i];
                }
                else
                {
                    suffixMax[i] = Math.Max(suffixMax[i + 1], nums[i]);
                }
            }
            int maxDiff = -1;
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < suffixMax[i + 1])
                {
                    maxDiff = Math.Max(maxDiff, suffixMax[i + 1] - nums[i]);
                }
            }
            return maxDiff;
        }
    }
}
