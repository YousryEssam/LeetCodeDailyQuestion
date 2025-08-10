namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P869
    {
        // 869. Reordered Power of 2
        private void addDigitsFrq(int[] digitsFrq, int n)
        {
            while (n > 0)
            {
                digitsFrq[n % 10]++;
                n /= 10;
            }
        }
        public bool ReorderedPowerOf2(int n)
        {
            int[] digitsFrq = new int[10];
            addDigitsFrq(digitsFrq, n);
            int curPowerOfTwo = 1;
            while (curPowerOfTwo <= 1000000000)
            {
                int temp = curPowerOfTwo;
                int[] curDigitsFrq = new int[10];
                bool isSameFrq = true;
                addDigitsFrq(curDigitsFrq, temp);
                for (int i = 0; i < 10; i++)
                {
                    if (curDigitsFrq[i] != digitsFrq[i])
                    {
                        isSameFrq = false;
                        break;
                    }
                }
                if (isSameFrq)
                {
                    return true;
                }
                curPowerOfTwo <<= 1; // Multiply by 2
            }
            return false;
        }
    }
}
