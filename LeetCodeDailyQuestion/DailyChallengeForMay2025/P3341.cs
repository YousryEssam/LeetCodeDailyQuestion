using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P3341
    {
        // 3341. Find Minimum Time to Reach Last Room I 
        // Day 7 / 5 / 2025
        public int MinTimeToReach(int[][] moveTime)
        {

            int n = moveTime.Length, m = moveTime[0].Length;
            int[,] minTime = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    minTime[i, j] = Int32.MaxValue;
                }
            }

            PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
            pq.Enqueue((0, 0), 0);

            int[,] dirs = new int[,] { { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 } };
            while (pq.Count > 0)
            {
                pq.TryDequeue(out (int, int) curr, out int currTime);
                for (int d = 0; d < 4; d++)
                {
                    int newRow = curr.Item1 + dirs[d, 0];
                    int newCol = curr.Item2 + dirs[d, 1];
                    if (newRow >= 0 && newRow < n && newCol >= 0 && newCol < m)
                    {
                        int newTime = Math.Max(currTime, moveTime[newRow][newCol]) + 1;
                        if (newTime < minTime[newRow, newCol])
                        {
                            minTime[newRow, newCol] = newTime;
                            pq.Enqueue((newRow, newCol), newTime);
                        }
                    }
                }
            }

            return minTime[n - 1, m - 1];
        }
    }
}
