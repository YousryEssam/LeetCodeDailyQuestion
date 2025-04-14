using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class P1534
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            // 1534. Count Good Triplets
            int result = 0, n = arr.Length;
            for(int i = 0; i < n; i ++)
            {
                for(int j = i + 1 ; j < n; j++)
                {
                    for(int k =  j + 1 ; k < n; k++)
                    {
                        if( Math.Abs(arr[i] - arr[j]) <= a && 
                            Math.Abs(arr[k] - arr[j]) <= b && 
                            Math.Abs(arr[k] - arr[i]) <= c)
                        {
                            result++;
                        }
                    }
                }
            }
            return result;
        }
    }
}
