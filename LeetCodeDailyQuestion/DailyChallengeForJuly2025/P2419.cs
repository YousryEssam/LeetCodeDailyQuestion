namespace LeetCodeDailyQuestion.DailyChallengeForJuly2025
{
    internal class P2419
    {
        // 30-07-2025
        // By Yousry Essam
        // 2419. Longest Subarray With Maximum Bitwise AND
        public int LongestSubarray(int[] nums)
        {
            int maxValue = nums[0];
            int longestLength = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxValue)
                {
                    maxValue = nums[i];
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int cnt = 0;
                while (i < nums.Length && nums[i] == maxValue)
                {
                    i++;
                    cnt++;
                }
                if (cnt > longestLength)
                {
                    longestLength = cnt;
                }
            }

            return longestLength;
        }
    }
}
