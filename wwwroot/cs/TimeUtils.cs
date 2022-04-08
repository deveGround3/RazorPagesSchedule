using System;
using System.Text;

namespace RazorPagesSchedule.wwwroot.cs
{
    public static class TimeUtils
    {
        public static DateTime StringToDate(string date)
        {
            DateTime dt = DateTime.ParseExact(date, "yyyy-MM-dd", null);
            return dt;
        }
        public static string DateToString(DateTime date)
        {
            StringBuilder dt = new StringBuilder();
            dt.Append(date.Year);
            dt.Append('-');
            if (date.Month < 10)
            {
                dt.Append("0");
            }
            dt.Append(date.Month);
            dt.Append('-');
            if (date.Day < 10)
            {
                dt.Append("0");
            }
            dt.Append(date.Day);
            return dt.ToString();
        }
    }
}