using System;
using task3;

namespace task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(DateService.GetDay("24.03.2022"));

            int day, month, year, day_1, month_1, year_1;
            while (!int.TryParse(Console.ReadLine(), out day) || day > 31)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out month) || month > 12)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out year) || year > 9999)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out day_1) || day_1 > 31)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out month_1) || month_1 > 12)
                Console.WriteLine("Неправильный ввод");
            while (!int.TryParse(Console.ReadLine(), out year_1) || year_1 > 9999)
                Console.WriteLine("Неправильный ввод");

            Console.WriteLine(DateService.GetDaysSpan(day, month, year, day_1, month_1, year_1));


           // DateService.GetDaysSpan(10, 10, 2022);
        }
    }
}