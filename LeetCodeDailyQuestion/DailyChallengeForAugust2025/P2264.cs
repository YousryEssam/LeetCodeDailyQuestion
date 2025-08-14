namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P2264
    {
        // 2264. Largest 3-Same-Digit Number in String\
        public string LargestGoodInteger(string num)
        {
            char maxDigit = '-';
            for(int i  =  0;  i < num.Length - 2; i++)
            {
                if (num[i] == num[i + 1] && num[i] == num[i + 2])
                {
                    if (num[i] > maxDigit)
                    {
                        maxDigit = num[i];
                        i+= 2; // Skip the next two characters since they are the same
                        if (maxDigit == '9') // Early exit if we found the largest digit
                        {
                            break;
                        }
                    }
                }
            }
            return maxDigit == '-' ? string.Empty : new string(maxDigit, 3);
        }
    }
}
