using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class PartitionEqualSubsetSum
    {
        //416. Partition Equal Subset Sum 

        int[,] dp;
        int[] arr;
        int sum = 0 , size;
        int DpSolution(int idx , int curSum)
        {
            if(curSum >= sum || idx >= size)
            {
                if (sum == curSum) return 1;
                return 0;
            }
            if (dp[idx, curSum] != -1) return dp[idx, curSum];
            dp[idx, curSum] = Math.Max(DpSolution(idx + 1, curSum), DpSolution(idx + 1, curSum + arr[idx]));
            return dp[idx, curSum];
        }
        public bool CanPartition(int[] nums)
        {
            size = nums.Length;
            for(int i = 0; i < size; i ++)
            {
                sum += nums[i];
            }
            if (sum % 2 == 1) return false;
            sum /= 2;
            arr = nums;
            dp = new int[size, sum + 10];
            for(int i = 0; i < size; i ++)
            {
                for (int j = 0; j < sum + 10; j++)
                {
                    dp[i, j] = -1;
                }
            }
            return DpSolution(0, 0) == 1;
        }
    }
}
