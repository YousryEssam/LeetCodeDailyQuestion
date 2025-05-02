using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P838
    {
        // 838. Push Dominoes
        public string PushDominoes(string dominoes)
        {
            string result = "";

            while (!result.Equals(dominoes))
            {
                result = dominoes;
                dominoes = dominoes.Replace("R.L", "-").Replace(".L", "LL").Replace("R.", "RR");
            }

            return result.Replace("-", "R.L");
        }
    }
}
