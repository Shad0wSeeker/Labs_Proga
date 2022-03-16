using System;

namespace task1
{
    public class Division
    {
        public static bool func(int a)
        {
            bool answer = true;
            if (a / 10 == a % 10)
            {
                return answer;
             }

            else
            {
                answer = false;
                return answer;
            }
        }
    }
   public class Program
    {

       public static void Main(string[] args)
        {
            
            bool flag = true;
            int a;

            while (flag)
            {

                while (true)
                {

                    Console.WriteLine("Enter your number: ");
                    a = Int32.Parse(Console.ReadLine());


                    if (a < 10 || a > 100)
                    {
                        Console.WriteLine("Enter correct number");
                        Console.WriteLine();
                        break;
                    }

                   if (Division.func(a) == true)
                    {
                        Console.WriteLine("The numbers are equal");
                    }
                   else
                    {
                        Console.WriteLine("The numbers are not equal");
                    }
                   
                    break;

                }

            
                Console.WriteLine("Enter 1, if you want to continue program, and 0 otherwise");
                int num = Int32.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        flag = true;
                        Console.WriteLine();
                        break;

                    case 0:
                        flag = false;
                        break;

                    default:
                        flag = false;
                        break;
                }

            }

        }
    }
}