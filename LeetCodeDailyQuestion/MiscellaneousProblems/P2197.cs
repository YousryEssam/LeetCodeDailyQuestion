namespace LeetCodeDailyQuestion.MiscellaneousProblems
{

    internal class P2197
    {
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
        public IList<int> ReplaceNonCoprimes(int[] nums)
        {
            var res = new List<int>();
            var stack = new Stack<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(nums[i]);
                }
                else
                {
                    int top = stack.Pop();
                    int num = nums[i];
                    if (GCD(top, num) > 1)
                    {
                        stack.Push((int)LCM(top, nums[i]));

                        while (stack.Count>1)
                        {
                            int first = stack.Pop();
                            int second = stack.Pop();
                            if (GCD(first, second) > 1)
                            {
                                stack.Push((int)LCM(first, second));
                            }
                            else
                            {
                                stack.Push(second);
                                stack.Push(first);
                                break;
                            }
                        }
                    }
                    else
                    {
                        stack.Push(top);
                        stack.Push(nums[i]);
                    }
                }
            }
            while (stack.Count > 0)
            {
                res.Add(stack.Pop());
            }
            res.Reverse();
            return res;
        }
    }
}
