namespace LeetCodeDailyQuestion.DailyChallengeForAugust2025
{
    internal class P3000
    {
        // 3000. Maximum Area of Longest Diagonal Rectangle
        private int MaxInt(int x , int y)
        {
            return x > y ? x : y;
        }
        private double MaxDouble(double x , double y)
        {
            return x > y ? x : y;
        }
        private double DiagonalCalc(int x , int y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        public int AreaOfMaxDiagonal(int[][] dimensions)
        {
            double maxDiagonal = 0;
            int maxArea = 0;
            for (int i = 0; i < dimensions.Length; i++)
            {
                maxDiagonal = MaxDouble(maxDiagonal, DiagonalCalc(dimensions[i][0], dimensions[i][1]));
            }
            for (int i = 0; i < dimensions.Length; i++)
            {
                if (DiagonalCalc(dimensions[i][0], dimensions[i][1]) == maxDiagonal)
                {
                    maxArea = MaxInt(maxArea, dimensions[i][0] * dimensions[i][1]);
                }
            }
            return maxArea;
        }
    }
}
