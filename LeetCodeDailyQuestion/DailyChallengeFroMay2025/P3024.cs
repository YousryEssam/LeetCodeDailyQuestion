namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P3024
    {
        // 3024. Type of Triangle
        // 19-5-2025
        private bool IsTriangle(int[] nums)
        {
            int val1 = nums[0] + nums[1];
            int val2 = nums[1] + nums[2];
            int val3 = nums[2] + nums[0];
            return val1 > nums[2] && val2 > nums[0] && val3 > nums[1];
        }
        public string TriangleType(int[] nums)
        {
            if (!IsTriangle(nums)) return "none";
            if (nums[0] == nums[1] && nums[1] == nums[2]) return "equilateral";
            if (nums[0] == nums[1] || nums[0] == nums[2] || nums[1] == nums[2]) return "isosceles";
            return "scalene";
        }
    }
}
