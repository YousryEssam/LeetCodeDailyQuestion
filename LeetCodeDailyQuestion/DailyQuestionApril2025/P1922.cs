using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.DailyQuestionApril2025
{
    class P1922
    {
        // 1922. Count Good Numbers

        long FastPower(long x, long  n, long mod)
        { // O(log(N))
            long res = 1;
            x %= mod;
            while (n > 0)
            {
                if (n % 2 == 1) res = ((res % mod) * (x % mod)) % mod;
                x = ((x % mod) * (x % mod)) % mod;
                n >>= 1;
            }
            return res % mod;
        }

        public int CountGoodNumbers(long n)
        {
            const long MOD = 1000000007;
            long evn = (n / 2) + (n % 2);
            long odd = n / 2;
            int result = (int)((FastPower(4, odd, MOD) % MOD) * (FastPower(5, evn, MOD) % MOD) % MOD);
            return result;
        }
    }
}
