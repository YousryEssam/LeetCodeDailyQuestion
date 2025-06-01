using System.Security.AccessControl;

namespace LeetCodeDailyQuestion.DailyChallengeFroMay2025
{
    internal class P1931
    {
        // 1931. Painting a Grid With Three Different Colors 
        // 18-5-2025
        // Topics  : Dynamic Programming
        private const int MOD = 1_000_000_007;
        private int m, n;
        private List<List<int>> states;
        private List<List<int>> transitions;

        public int ColorTheGrid(int m_input, int n_input)
        {
            m = m_input;
            n = n_input;
            states = new List<List<int>>();

            // Step 1: Build all valid columns using backtracking(make sure columns are not the same color)
            BuildColumns(new List<int>());

            int K = states.Count; // Number of valid columns

            // Step 2: Build transition graph between valid columns
            transitions = new List<List<int>>(new List<int>[K]);
            for (int i = 0; i < K; ++i)
                transitions[i] = new List<int>();

            for (int i = 0; i < K; ++i)
            {
                for (int j = 0; j < K; ++j)
                {
                    if (IsCompatible(states[i], states[j]))
                        transitions[i].Add(j);
                }
            }

            // Step 3: Dynamic programming
            var dp = new int[K];
            for (int i = 0; i < K; ++i)
            {
                dp[i] = 1; 
            }

            for (int col = 1; col < n; ++col)
            {
                var newDp = new int[K];

                for (int i = 0; i < K; ++i)
                {
                    foreach (var prev in transitions[i])
                    {
                        newDp[i] = (newDp[i] + dp[prev]) % MOD;
                    }
                }

                dp = newDp;
            }

            int total = 0;
            foreach (var count in dp)
            {
                total = (total + count) % MOD;
            }

            return total;
        }
        private void BuildColumns(List<int> current)
        {
            if (current.Count == m)
            {
                states.Add(new List<int>(current));
                return;
            }

            for (int color = 0; color < 3; ++color)
            {
                if (current.Count > 0 && current[current.Count - 1] == color)
                    continue; // No two adjacent same color vertically

                current.Add(color);
                BuildColumns(current);
                current.RemoveAt(current.Count - 1); // backtrack
            }
        }

        // Check two columns compatibility (horizontal conflict)
        private bool IsCompatible(List<int> a, List<int> b)
        {
            for (int i = 0; i < m; ++i)
            {
                if (a[i] == b[i])
                    return false;
            }
            return true;
        }
        // Helper Methods
        private int GetColorInIndex(int idx, int mask)
        {
            int firstBit = idx * 2;
            int color = (mask >> firstBit) & 3;
            return color;
        }
        private int SetColorInIndex(int idx, int mask, int color)
        {
            int shift = idx * 2;
            int clearMask = ~(3 << shift);
            mask &= clearMask;
            mask |= (color & 3) << shift;
            return mask;
        }

    }
}