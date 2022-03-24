using System;

namespace task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("enter z:");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("enter b:");
            double b = double.Parse(Console.ReadLine());

            Class2.func(z, b);
        }
    }
}