namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P2966
    {
        // 18-06-2025
        // By Yousry Essam
        // 2966. Divide Array Into Arrays With Max Difference
        private bool ValidArray(int[] nums, int numOfArrays, int difference)
        {
            for (int i = 0; i < numOfArrays; i++)
            {
                int firstIdx = i * 3;
                int lastIdx = (i + 1) * 3 - 1;
                if (nums[lastIdx] - nums[firstIdx] > difference)
                {
                    return false;
                }
            }
            return true;
        }
        public int[][] DivideArray(int[] nums, int k)
        {
            int numOfArrays = nums.Length / 3;
            Array.Sort(nums);
            if (!ValidArray(nums, numOfArrays, k))
            {
                return new int[0][];
            }
            int idx = 0;
            int[][] result = new int[numOfArrays][];
            for (int i = 0; i < numOfArrays; i++)
            {
                result[i] = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    result[i][j] = nums[idx++];
                }
            }
            return result;
        }
    }
}