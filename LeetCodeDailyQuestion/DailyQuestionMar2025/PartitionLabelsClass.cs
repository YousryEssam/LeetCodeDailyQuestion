using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestion
{
    class PartitionLabelsClass
    {
        // Day 30-3-2025 problem 763. Partition Labels.
        public IList<int> PartitionLabels(string s)
        {
            IList<int> labels = new List<int>();
            var pairs = new (int, int)[26];
            for (int i = 0; i < 26; i++)
            {
                pairs[i].Item1 = pairs[i].Item2 = -1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (pairs[s[i] - 'a'].Item1 == -1)
                {
                    pairs[s[i] - 'a'].Item1 = i;
                }
                pairs[s[i] - 'a'].Item2 = i;
            }
            int StartRange = 0, EndRange = pairs[s[0] - 'a'].Item2;
            for (int i = 0; i < s.Length; i++)
            {
                if (EndRange < i)
                {
                    StartRange = i;
                }
                EndRange = Math.Max(EndRange, pairs[s[i] - 'a'].Item2);
                if (EndRange == i)
                {
                    labels.Add(EndRange - StartRange + 1);
                }
            }
            return labels;
        }
    }
}
