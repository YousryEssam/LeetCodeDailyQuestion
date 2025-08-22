namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P3195
    {
        // 3195. Find the Minimum Area to Cover All Ones I
        public int MinimumArea(int[][] grid)
        {
            int minX = int.MaxValue, maxX = int.MinValue;
            int minY = int.MaxValue, maxY = int.MinValue;
            for(int i  = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        minX = Math.Min(minX, i);
                        maxX = Math.Max(maxX, i);
                        minY = Math.Min(minY, j);
                        maxY = Math.Max(maxY, j);
                    }
                }
            }
            return (maxX - minX + 1) * (maxY - minY + 1);
        }
    }
}
