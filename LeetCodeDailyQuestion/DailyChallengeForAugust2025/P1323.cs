namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P1323
    {
        // 1323. Maximum 69 Number
        public int Maximum69Number(int num)
        {
            char[] numArray = num.ToString().ToCharArray();
            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] == '6')
                {
                    numArray[i] = '9';
                    return int.Parse(new string(numArray));
                }
            }
            return num;
        }
    }
}
