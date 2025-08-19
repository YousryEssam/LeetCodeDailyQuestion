namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P2348
    {
        // 2348. Number of Zero-Filled Subarrays
        public long ZeroFilledSubarray(int[] nums)
        {
            long count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                long tempCnt = 0;
                while (i < nums.Length && nums[i] == 0)
                {
                    tempCnt++;
                    i++;
                }
                count += ((tempCnt * (tempCnt + 1)) / 2);
            }
            return count;
        }
    }
}
