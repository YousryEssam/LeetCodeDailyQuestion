namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P2918
    {
        //2918. Minimum Equal Sum of Two Arrays After Replacing Zeros 
        // 10-5-2025

        public long MinSum(int[] nums1, int[] nums2)
        {
            int zeroCounter1 = 0, zeroCounter2 = 0;
            long sumArr1 = 0, sumArr2 = 0;
            foreach (int i in nums1)
            {
                if (i == 0) zeroCounter1++;
                sumArr1 += i;
            }
            foreach (int i in nums2)
            {
                if (i == 0) zeroCounter2++;
                sumArr2 += i;
            }
            if (zeroCounter1 > 1)
            {
                sumArr1 += (zeroCounter1 - 1);
                zeroCounter1 = 1;
            }
            if (zeroCounter2 > 1)
            {
                sumArr2 += (zeroCounter2 - 1);
                zeroCounter2 = 1;
            }
            if (zeroCounter1 == zeroCounter2 && zeroCounter1 == 1)
            {
                return Math.Max(sumArr1, sumArr2) + 1;
            }
            else if (zeroCounter1 != zeroCounter2)
            {
                if (zeroCounter1 == 1 && sumArr1 < sumArr2) return sumArr2;
                else if (zeroCounter2 == 1 && sumArr1 > sumArr2) return sumArr1;
            }
            else if (sumArr1 == sumArr2)
            {
                return sumArr1;
            }
            return -1;
        }
    }
}
