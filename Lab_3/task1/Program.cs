using System;

namespace task1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("enter a number:");
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(Class1.func(num));
        }
    }
}