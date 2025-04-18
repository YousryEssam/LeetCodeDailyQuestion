using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P38
    {
        // 38. Count and Say
        public string CountAndSay(int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("1");
            for(int i = 1; i < n; i ++ ) {
                StringBuilder temp = new StringBuilder();
                int cnt = 1;
                for(int j = 1; j < stringBuilder.Length; j ++)
                {
                    if (stringBuilder[j] == stringBuilder[j - 1])
                    {
                        cnt++;
                    }
                    else
                    {
                        temp.Append(cnt.ToString());
                        temp.Append(stringBuilder[j - 1]);
                        cnt = 1;
                    }
                }
                temp.Append(cnt.ToString());
                temp.Append(stringBuilder[stringBuilder.Length - 1]);
                cnt = 1;
                stringBuilder = temp;
            }
            return stringBuilder.ToString();
        }
    }
}
