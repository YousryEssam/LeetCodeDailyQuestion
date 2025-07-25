namespace LeetCodeDailyQuestion.DailyChallengeForJuly2025
{
    internal class P3487
    {
        // 25-07-2025
        // By Yousry Essam
        // 3487. Maximum Unique Subarray Sum After Deletion
        public int MaxSum(int[] nums)
        {
            int maxSum = 0;
            bool notEmpty = false;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] && nums[i] >= 0)
                {
                    maxSum += nums[i];
                    if (!notEmpty && nums[i - 1] >= 0)
                    {
                        maxSum += nums[i - 1];
                    }
                    notEmpty = true;
                }
            }


            return notEmpty ? maxSum : nums[nums.Length - 1];
        }
    }
}
