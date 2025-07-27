namespace LeetCodeDailyQuestion.DailyChallengeForJuly2025
{
    internal class P2210
    {
        // 27-07-2025
        // By Yousry Essam
        // 2210. Count Hills and Valleys in an Array
        public int CountHillValley(int[] nums)
        {
            int cnt = 0;
            int[] filterdArray = new int[nums.Length];
            filterdArray[0] = nums[0];
            int idx = 1;
            for (int  i =  1; i < nums.Length; i++)
            {
                if (nums[i] != filterdArray[idx-1])
                {
                    filterdArray[idx] = nums[i];
                    idx++;
                }
            }
            for(int i = 1; i < idx - 1; i++)
            {
                if ((filterdArray[i] > filterdArray[i - 1] && filterdArray[i] > filterdArray[i + 1]) ||
                    (filterdArray[i] < filterdArray[i - 1] && filterdArray[i] < filterdArray[i + 1]))
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
