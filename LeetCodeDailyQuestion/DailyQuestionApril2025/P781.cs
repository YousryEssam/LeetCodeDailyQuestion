using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    internal class P781
    {
        // 781. Rabbits in Forest
        public int NumRabbits(int[] answers)
        {
            int NumberOfRabbits = 0;
            Dictionary<int, int> Frq = new Dictionary<int, int>();
            foreach (int answersItem in answers)
            {
                if (!Frq.ContainsKey(answersItem)) {
                    NumberOfRabbits += answersItem + 1;
                    Frq.Add(answersItem, answersItem);
                }
                else
                {
                    if (Frq[answersItem] > 0) 
                    {
                        Frq[answersItem]--;
                    }
                    else
                    {
                        NumberOfRabbits += answersItem + 1;
                        Frq[answersItem] = answersItem;
                    }
                }
            }
            return NumberOfRabbits;
        }
    }
}
