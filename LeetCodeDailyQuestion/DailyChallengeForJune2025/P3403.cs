using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeForJune2025
{
    internal class P3403
    {
        // 04-06-2025
        // 3403. Find the Lexicographically Largest String From the Box I
        public string AnswerString(string word, int numFriends)
        {
            if (numFriends == 1) { return word; }
            int resultLength = 0;
            StringBuilder stringBuilder = new StringBuilder(word.Length);
            for (int i = 0; i < word.Length; i++)
            {
                if (resultLength == 0 || word[i] >= stringBuilder[0])
                {
                    int curLen = 0;
                    bool isLexicographicallyLarger = false;
                    for (int j = i; j < Math.Min(i + word.Length + 1 - numFriends, word.Length); j++)
                    {
                        if (curLen >= resultLength || word[j] > stringBuilder[curLen])
                        {
                            isLexicographicallyLarger = true;
                        }
                        else if (word[j] < stringBuilder[curLen] && !isLexicographicallyLarger)
                        {
                            break;
                        }

                        if (curLen >= stringBuilder.Length)
                        {
                            stringBuilder.Append(word[j]);
                        }
                        else
                        {
                            stringBuilder[curLen] = word[j];
                        }
                        curLen++;
                    }
                    if (isLexicographicallyLarger)
                    {
                        resultLength = curLen;
                    }
                }
            }
            return stringBuilder.ToString().Substring(0, resultLength);
        }
    }
}
