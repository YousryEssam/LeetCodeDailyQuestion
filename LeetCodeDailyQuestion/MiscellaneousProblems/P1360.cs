namespace LeetCodeDailyQuestion.MiscellaneousProblems
{
    internal class P1360
    {
        // 1360. Number of Days Between Two Dates
        public int DaysBetweenDates(string date1, string date2)
        {
            DateTime dt1 = DateTime.Parse(date1), dt2 = DateTime.Parse(date2);
            return Math.Abs((dt2 - dt1).Days);
        }
    }
}
