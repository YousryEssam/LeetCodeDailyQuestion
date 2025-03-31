using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestion
{
    class PutMarblesInBags
    {
        // Day 31-3-2025 problem 2551. Put Marbles in Bags

        public long PutMarbles(int[] weights, int k)
        {
            int size = weights.Length;
            int[] pairWeights = new int[size - 1];

            for (int i = 0; i < size-1; i++) {
                pairWeights[i] = weights[i] + weights[i + 1];
            }

            Array.Sort(pairWeights);

            long answer = 0;
            for (int i = 0; i < k-1; i++) {
                answer += pairWeights[size - 2 - i] - pairWeights[i];
            }
            return answer;
        }
    }
}
