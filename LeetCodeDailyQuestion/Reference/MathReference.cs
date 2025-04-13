using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDailyQuestion.Reference
{
    class MathReference
    {
        public static long FastPower(long x, long n, long mod) // O(log(N))
        {
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
    }
}
