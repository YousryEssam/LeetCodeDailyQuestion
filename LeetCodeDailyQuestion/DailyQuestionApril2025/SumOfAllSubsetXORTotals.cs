using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class SumOfAllSubsetXORTotals
    {
        // 1863. Sum of All Subset XOR Totals
        int totalSum = 0;
        private void TryAllSubsets(int idx, int sum, int[] arr)
        {
            if (idx >= arr.Length)
            {
                totalSum += sum;
                return;
            }
            TryAllSubsets(idx + 1, sum, arr);
            TryAllSubsets(idx + 1, (sum ^ arr[idx]), arr);
        }
        public int SubsetXORSum(int[] nums)
        {
            TryAllSubsets(0, 0, nums);
            return totalSum;
        }
    }
}
