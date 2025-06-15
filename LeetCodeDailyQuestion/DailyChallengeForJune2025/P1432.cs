namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P1432
    {
        // 15-06-2025
        // 1432. Max Difference You Can Get From Changing an Integer 
        public int MaxDiff(int num)
        {
            int maxValue = 0;
            int minValue = num;
            string maxStr = num.ToString();
            string minStr = num.ToString();

            int idxMax = 0;
            for (int i = 0; i < maxStr.Length; i++)
            {
                if (maxStr[i] < '9')
                {
                    idxMax = i;
                    break;
                }
            }
            maxStr = maxStr.Replace(maxStr[idxMax], '9');
            if (minStr[0] != '1')
            {
                minStr = minStr.Replace(minStr[0], '1');
            }
            else
            {
                int idxMin = 0;
                for (int i = 1; i < minStr.Length; i++)
                {
                    if (minStr[i] > '0' && minStr[i] != '1')
                    {
                        idxMin = i;
                        break;
                    }
                }
                if(idxMin != 0 )
                   minStr = minStr.Replace(minStr[idxMin], '0');
            }
            maxValue = int.Parse(maxStr);
            minValue = int.Parse(minStr);
            return maxValue - minValue;
        }
    }
}
