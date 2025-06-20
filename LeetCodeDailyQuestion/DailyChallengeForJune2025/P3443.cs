namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P3443
    {
        // 20-06-2025
        // By Yousry Essam
        // 3443. Maximum Manhattan Distance After K Changes
        private int ManhattanDistance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
        private int BounsMoves(int left, int right, int up, int down, int k)
        {
            int bouns = 0;
            if (left > 0 && right > 0)
            {
                int temp = Math.Min(left, right);
                temp = Math.Min(temp, k);
                bouns += temp;
                k -= temp;
            }
            if (up > 0 && down > 0)
            {
                int temp = Math.Min(up, down);
                temp = Math.Min(temp, k);
                bouns += temp;
                k -= temp;
            }
            return 2 * bouns;
        }
        public int MaxDistance(string s, int k)
        {
            int maxDistance = 0;
            int left = 0, right = 0, up = 0, down = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'N') up++;
                else if (s[i] == 'S') down++;
                else if (s[i] == 'E') right++;
                else left++;
                int calcValue = ManhattanDistance(left, right, up, down);
                calcValue += BounsMoves(left, right, up, down, k);

                maxDistance = Math.Max(maxDistance, calcValue);
            }

            return maxDistance;
        }
    }
}
