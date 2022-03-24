using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class DateService
    {
        public static void GetDay(string date)
        {
            DateTime dateValue = DateTime.Parse(date);
            Console.WriteLine(dateValue.ToString("dddd"));
        }

        public static void GetDaysSpan(int day, int month, int year)
        {
            TimeSpan span = new DateTime(year, month, day) - DateTime.UtcNow;
            Console.WriteLine(span.Days);
        }
    }
}
