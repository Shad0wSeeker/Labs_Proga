using System;

namespace _153502_Danilenko
{
    class Program
    {

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 nubmers: ");
            a = Int32.Parse(Console.ReadLine());
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The result of division: ");
            double c = (double)a / b;
            Console.WriteLine(c);
        }
    }
}