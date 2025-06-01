using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P2094
    {
        // 2094. Finding 3-Digit Even Numbers
        // 12-5-2025
        public int[] FindEvenNumbers(int[] digits)
        {
            IList<int> numbers = new List<int>();
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = 0; j < digits.Length; j++)
                {
                    for (int k = 0; k < digits.Length; k++)
                    {
                        if (digits[k] % 2 == 0 && digits[i] > 0 && i != k && i != j && j != k)
                        {
                            int number = 0;
                            number += digits[i] * 100;
                            number += digits[j] * 10;
                            number += digits[k];
                            set.Add(number);
                        }
                    }
                }
            }
            foreach (int number in set)
            {
                numbers.Add(number);
            }
            int[] arr = numbers.ToArray<int>();
            Array.Sort(arr);
            return arr;
        }

        // Best  Performance
        public int[] FindEvenNumbersPerformance(int[] digits)
        {
            var res = new List<int>();
            var d = new int[10];

            foreach (var num in digits)
            {
                d[num]++;
            }

            var n = new int[10];

            for (int num = 100; num < 1000; num += 2)
            {
                var ones = num % 10;
                var tens = (num / 10) % 10;
                var hund = num / 100;

                n[ones]++;
                n[tens]++;
                n[hund]++;

                if (n[ones] <= d[ones] && n[tens] <= d[tens] && n[hund] <= d[hund])
                {
                    res.Add(num);
                }

                n[ones] = 0;
                n[tens] = 0;
                n[hund] = 0;
            }

            return res.ToArray();
        }
    }
}
