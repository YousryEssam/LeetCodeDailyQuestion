using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P1295
    {
        // 1295. Find Numbers with Even Number of Digits
        public int FindNumbers(int[] nums)
        {
            int counter = 0;
            foreach (int num in nums) {
                int numberOfDigits = 0;
                int temp = num;
                while (temp > 0)
                {
                    numberOfDigits++;
                    temp /= 10;
                }
                if (numberOfDigits % 2 == 0) counter++;
            }
            return counter;
        }
    }
}
