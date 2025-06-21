namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P3085
    {
        // 21-06-2025
        // By Yousry Essam
        // 3085. Minimum Deletions to Make String K-Special

        public int MinimumDeletions(string word, int k)
        {
            Span<int> chars = stackalloc int[26]; //* Initialize frequency span.
            int length = word.Length, min = Int32.MaxValue;

            for (int i = 0; i < length; i++) //* Add every char to frequency span.
                chars[word[i] - 97]++;

            /* If a frequency value of a char taken as min value,
            * lower frequency values directly add "Low Frequency Value" to the "Deletions",
            * higher frequency values add "High Frequency Value" - "Current (Min) Value" - "k"
            * if differance between two is bigger than "k" */
            for (int i = 0; i < 26; i++)
            {
                int cur = chars[i];
                if (cur == 0) continue; //* Skip empty frequencies.

                int del = 0;

                for (int j = 0; j < 26; j++)
                {
                    int temp = chars[j];

                    if (temp == 0) continue; //* Skip empty frequencies.

                    /* if "Temp" is bigger than "Current" add "Temp"
                    * else if distance between "Current" and "Temp" is bigger than "k" add "Temp" - "Current" - "k"
                    * else add 0 */
                    del += cur > temp ? temp : temp - cur - k > 0 ? temp - cur - k : 0;
                }

                if (del < min) min = del; //* Update the result value.
            }

            return min;
        }
    }
}
