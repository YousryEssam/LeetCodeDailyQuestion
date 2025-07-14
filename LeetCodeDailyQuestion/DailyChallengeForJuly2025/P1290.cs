namespace LeetCodeDailyQuestion.DailyChallengeForJuly2025
{
    internal class P1290
    {
        // 14-07-2025
        // By Yousry Essam
        // 1290. Convert Binary Number in a Linked List to Integer
        public int GetDecimalValue(ListNode head)
        {
            int decimalValue = 0;
            int powOfTwo = 1;
            var listNode = head;
            while (listNode.next != null)
            {
                powOfTwo *= 2;
                listNode = listNode.next;
            }
            while (head.next != null)
            {
                decimalValue += head.val * powOfTwo;
                powOfTwo /= 2;
                head = head.next;
            }
            decimalValue += head.val * powOfTwo;
            return decimalValue;
        }
    }
}
