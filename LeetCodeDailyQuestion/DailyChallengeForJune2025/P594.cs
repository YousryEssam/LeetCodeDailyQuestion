namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P594
    {
        // 30-06-2025
        // By Yousry Essam
        // 594. Longest Harmonious Subsequence
        public int FindLHS(int[] nums)
        {
            Array.Sort(nums);
            int LHS = 0;
            int l = 0, r = 0;
            while (r < nums.Length)
            {
                if (nums[r] - nums[l] == 0)
                {
                    r++;
                }
                else if (nums[r] - nums[l] == 1)
                {
                    LHS = Math.Max(LHS, r - l + 1);
                    r++;
                }
                else
                {
                    l++;
                }
            }
            return LHS;
        }
    }
}
