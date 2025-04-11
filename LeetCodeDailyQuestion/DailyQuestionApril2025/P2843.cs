using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class P2843
    {
        // 2843. Count Symmetric Integers
        public int CountSymmetricIntegers(int low, int high)
        {
            int result = 0;
            for(int i = low; i <= high; )
            {
                string curNum = i.ToString();
                int cnt = curNum.Length;
                if( curNum.Length%2 == 1)
                {
                    int newI = 1;
                    while (cnt > 0) {
                        newI *= 10;
                        cnt--;
                    }
                    i = newI;

                }
                else
                {
                    int sum1 = 0, sum2 = 0;
                    for(int j  =0; j < cnt; j ++)
                    {
                        if(j < cnt/2)
                        {
                            sum1 += curNum[j] - '0';
                        }
                        else
                        {
                            sum2 += curNum[j] - '0';
                        }
                    }
                    if(sum1 == sum2)
                    {
                        result++;
                    }
                    i++;
                }
            }
            return result;
        }
    }
}
