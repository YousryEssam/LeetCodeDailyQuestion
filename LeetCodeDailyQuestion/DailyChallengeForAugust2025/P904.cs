namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P904
    {
        // 03-08-2025
        // By Yousry Essam
        // 904. Fruit Into Baskets
        private struct Baskets
        {
            public int fruit;
            public int count;
        }
        public int TotalFruit(int[] fruits)
        {
            int maxFruits = 0;
            Baskets basket1 = new Baskets { fruit = -1, count = 0 };
            Baskets basket2 = new Baskets { fruit = -1, count = 0 };
            int left = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == basket1.fruit || fruits[i] == basket2.fruit)
                {
                    if (fruits[i] == basket1.fruit)
                    {
                        basket1.count++;
                    }
                    else
                    {
                        basket2.count++;
                    }
                }
                else
                {
                    if (basket1.fruit == -1)
                    {
                        basket1.fruit = fruits[i];
                        basket1.count = 1;
                    }
                    else if (basket2.fruit == -1)
                    {
                        basket2.fruit = fruits[i];
                        basket2.count = 1;
                    }
                    else
                    {
                        while (left <= i && basket1.count > 0 && basket2.count > 0)
                        {
                            if (fruits[left] == basket1.fruit)
                            {
                                basket1.count--;
                            }
                            else
                            {
                                basket2.count--;
                            }
                            left++;
                        }
                        if (basket1.count == 0)
                        {
                            basket1.fruit = fruits[i];
                            basket1.count = 1;
                        }
                        else
                        {

                            basket2.fruit = fruits[i];
                            basket2.count = 1;
                        }
                    }
                }
                maxFruits = Math.Max(maxFruits, basket1.count + basket2.count);

            }
            return maxFruits;
        }
    }
}
