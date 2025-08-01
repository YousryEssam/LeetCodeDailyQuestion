namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P118
    {
        // 01-08-2025
        // By Yousry Essam
        // 118. Pascal's Triangle
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        int value = result[i - 1][j - 1] + result[i - 1][j];
                        row.Add(value);
                    }
                }
                result.Add(row);
            }
            return result;
        }
    }
}
