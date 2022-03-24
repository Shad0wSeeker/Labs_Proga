using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class DateService
    {
        public static String GetDay(string date)
        {
            DateTime dateValue = DateTime.Parse(date);
            return dateValue.ToString("dddd");
            //Console.WriteLine(dateValue.ToString("dddd"));
        }

        public static int GetDaysSpan(int day, int month, int year, int day_1, int month_1, int year_1)
        {
            TimeSpan span = new DateTime(year, month, day) - new DateTime(year_1, month_1, day_1);
            return span.Days;
            //Console.WriteLine(span.Days);
        }
    }
}
