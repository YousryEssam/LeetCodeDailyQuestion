using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P2145
    {
        // 2145. Count the Hidden Sequences
        public int NumberOfArrays(int[] differences, long lower, long upper)
        {
            long numberOfArrays = 0;
            long[] frq = new long[differences.Length + 1];
            long maxValue = long.MinValue;
            long minValue = long.MaxValue;
            for (int i = 0; i < differences.Length; i++)
            {
                frq[i + 1] += differences[i];
                if(i > 0)
                {
                    frq[i] += frq[i - 1];
                }
                maxValue = Math.Max(maxValue, frq[i]);
                minValue = Math.Min(minValue, frq[i]);
            }
            frq[differences.Length] += frq[differences.Length - 1];
            maxValue = Math.Max(maxValue, frq[differences.Length]);
            minValue = Math.Min(minValue, frq[differences.Length]);
            long addedValue = lower - minValue;
            minValue += addedValue;
            maxValue += addedValue;
            numberOfArrays = Math.Max(numberOfArrays, upper - maxValue + 1);
            return (int)numberOfArrays;
        }

        // Better Performance
        public int NumberOfArrays2(int[] differences, int lower, int upper)
        {
            long min = 0, max = 0;
            int value = 0;
            foreach (int diff in differences)
            {
                value += diff;
                if (min > value) min = value;
                if (max < value) max = value;
            }
            long count = (long)(upper) - (long)lower - max + min + 1;
            if (count < 0) count = 0;
            return (int)count;
        }
    }
}
