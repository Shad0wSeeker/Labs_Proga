using System;

namespace task2
{
   
    public class Program
    {
        public static string func(int x, int y)
        {

            string answer_1, answer_2, answer_3;
            answer_1 = "Да";
            answer_2 = "На границе";
            answer_3 = "Нет";

            if ((x * x + y * y) < 225)
            {
                return answer_1;
                
            }
            else if ((x * x + y * y) == 225)
            {
                return answer_2;
                
            }
            else if ((x * x + y * y) > 625)
            {
                return answer_1;
                
            }
            else if ((x * x + y * y) == 625)
            {
                return answer_2;
                
            }
            else
            {
                return answer_3;
                
            }
        }
        static void Main(string[] args)
        {

            bool flag = true;
            int x, y;
           


            while (flag)
            {
                Console.WriteLine("Enter x and y: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine(func(x, y));
                    Console.WriteLine();
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