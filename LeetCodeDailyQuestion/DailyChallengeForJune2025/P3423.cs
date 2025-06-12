namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P3423
    {
        // 12-06-2025
        // 3423. Maximum Difference Between Adjacent Elements in a Circular Array 
        public int MaxAdjacentDistance(int[] nums)
        {
            int answer = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int val1 = nums[i];
                int val2 = nums[i + 1];
                if (val1 >= val2)
                {
                    if(answer <= val1 - val2)
                    {
                        answer = val1 - val2;
                    }
                }
                else
                {
                    if(answer <= val2 - val1)
                    {
                        answer = val2 - val1;
                    }
                }
            }

            return Math.Max(answer, Math.Abs(nums[0] - nums[nums.Length-1]));
        }
    }
}
