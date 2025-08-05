namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P3477
    {
        // 3477. Fruits Into Baskets II
        public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
        {
            int unplacedCount = 0;
            for(int i = 0; i < fruits.Length; i++)
            {
                bool placed = false;
                for (int  j = 0; j < baskets.Length; j++)
                {
                    if (baskets[j] >= fruits[i] && baskets[j] != -1)
                    {
                        baskets[j] = -1;
                        placed = true;
                        break;
                    }
                }
                if(!placed)
                {
                    unplacedCount++;
                }
            }
            return unplacedCount;
        }
    }
}
