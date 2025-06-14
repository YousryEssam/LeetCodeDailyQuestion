namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P2566
    {

        // 14-06-2025
        // 2566. Maximum Difference by Remapping a Digit 
        public int MinMaxDifference(int num)
        {
            int maxValue = 0;
            int minValue = num;
            string maxStr = num.ToString();
            string minStr = num.ToString();

            int idx = 0;
            for (int i = 0; i < maxStr.Length; i++)
            {
                if (maxStr[i] < '9')
                {
                    idx = i;
                    break;
                }
            }
            minStr = minStr.Replace(minStr[0], '0');
            maxStr = maxStr.Replace(maxStr[idx], '9');
            maxValue = int.Parse(maxStr);
            minValue = int.Parse(minStr);
            return maxValue - minValue;
        }
    }
}
