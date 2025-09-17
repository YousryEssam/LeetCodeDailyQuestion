namespace LeetCodeDailyQuestion.MiscellaneousProblems
{
    internal class P35
    {
        public int SearchInsert(int[] nums, int target)
        {
            int idx = 0;
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                //int mid = left + (right - left) / 2;
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] <= target)
                {
                    left = mid + 1;
                    idx = mid + 1;
                }
                else
                {
                    right = mid - 1;
                    idx = mid;
                }
            }
            return idx;
        }
    }
}
