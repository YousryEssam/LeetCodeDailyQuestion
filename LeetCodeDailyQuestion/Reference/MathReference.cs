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
        public static long GCD(long a, long b) // O(log(min(a,b)))
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static long LCM(long a, long b) // O(log(min(a,b)))
        {
            return (a / GCD(a, b)) * b;
        }
    }
}
