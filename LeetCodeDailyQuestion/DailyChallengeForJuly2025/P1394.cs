namespace LeetCodeDailyQuestion.DailyChallengeForJuly2025
{
    internal class P1394
    {
        // 05-07-2025
        // By Yousry Essam
        // 1394. Find Lucky Integer in an Array
        public int FindLucky(int[] arr)
        {
            int largestLuckyInteger = -1;
            Dictionary<int, int> frq = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (frq.ContainsKey(arr[i]))
                {
                    frq[arr[i]]++;
                }
                else
                {
                    frq.Add(arr[i], 1);
                }
            }
            foreach (var i in frq)
            {
                if (i.Value == i.Key)
                {
                    largestLuckyInteger = Math.Max(largestLuckyInteger, i.Value);
                }
            }

            return largestLuckyInteger;
        }
    }
}
