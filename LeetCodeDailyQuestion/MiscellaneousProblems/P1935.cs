namespace LeetCodeDailyQuestion.MiscellaneousProblems
{
    internal class P1935
    {
        // 1935. Maximum Number of Words You Can Type
        // Beats 100.00% 
        public int CanBeTypedWords(string text, string brokenLetters)
        {
            int MaxNumberOfWords = 0;
            bool[] BadKeys = new bool[26];
            for (int i = 0; i < brokenLetters.Length; i++)
            {
                BadKeys[brokenLetters[i] - 'a'] = true;
            }
            bool hasBadKey = false, sameWord = false;
            foreach(var i in text)
            {
                if(i == ' ')
                {
                    if(sameWord)
                    {
                        if(!hasBadKey)
                        {
                            MaxNumberOfWords++;
                        }
                    }
                    sameWord = false;
                    hasBadKey = false;
                }
                else
                {
                    sameWord = true;
                    if (BadKeys[i-'a'])
                    {
                        hasBadKey = true;
                    }
                }
            }
            if (sameWord)
            {
                if (!hasBadKey)
                {
                    MaxNumberOfWords++;
                }
            }
            return MaxNumberOfWords;
        }
    }
}