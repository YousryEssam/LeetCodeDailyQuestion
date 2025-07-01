namespace LeetCodeDailyQuestion.DailyChallengeForJuly2025
{
    internal class P3330
    {
        // 01-07-2025
        // By Yousry Essam
        // 3330. Find the Original Typed String I
        public int PossibleStringCount(string word)
        {
            int answer = 1;
            int temp = 0; 
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    temp++;
                }
                else
                {
                    answer += (temp - 1);
                    temp = 1;
                }
            }
            return answer + temp - 1;
        }
    }
}
