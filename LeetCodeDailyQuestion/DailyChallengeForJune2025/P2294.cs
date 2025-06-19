namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P2294
    {
        // 19-06-2025
        // By Yousry Essam
        // 2294. Partition Array Such That Maximum Difference Is K
        public int PartitionArray(int[] nums, int k)
        {
            int result = 1;
            Array.Sort(nums);
            int startRange = 0, n = nums.Length; 
            for(int i = 0; i < n; i ++ )
            {
                if (nums[i] - nums[startRange] > k )
                {
                    result++;
                    startRange = i;
                }
            }
            return result;
        }
    }
}
