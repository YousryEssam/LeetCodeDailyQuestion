using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P1399
    {
        // 1399. Count Largest Group
        int SumOfDigits(int n)
        {
            int sum = 0;
            while(n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        public int CountLargestGroup(int n)
        {
            int[] frq = new int[50];
            int MaxGroup = 0, cnt = 0;
            for(int i = 1; i <= n; i ++)
            {
                int value = SumOfDigits(i);
                frq[value]++;
                if( frq[value] > MaxGroup)
                {
                    MaxGroup = frq[value];
                    cnt = 1;
                }
                else if (frq[value] == MaxGroup)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
