using LeetCodeDailyQuestion.DailyQuestion;

namespace LeetCodeDailyQuestion
{
    internal class Program
    {
        static void TestCode2780()
        {
            // Testing Code : MinimumIndexOfValidSplit 2780 
            IList<int> ints = new List<int>([1, 2, 2, 2]);
            IList<int> ints2 = new List<int>([2, 1, 3, 1, 1, 1, 7, 1, 2, 1]);
            Solution solution = new Solution();
            //solution.MinimumIndex(ints);
            solution.MinimumIndex(ints2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestCode2780();


        }
    }
}
