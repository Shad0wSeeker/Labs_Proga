using System;
using System.Collections.Generic;


namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Quadratic_equation> eqs = new List<Quadratic_equation>(0);

            eqs.Add(new Quadratic_equation());
            eqs.Add(new Quadratic_equation(17, 0, 8));
            eqs.Add(new Quadratic_equation(16, 0, -30));
            eqs.Add(new Quadratic_equation(1, 14, 7));
            eqs.Add(new Quadratic_equation(781));
            eqs.Add(new Quadratic_equation(14, 7));
            eqs.Add(new Quadratic_equation(11, 11, -10));
            eqs.Add(new Quadratic_equation(0, 16, 8));



            for (int i = 0; i < eqs.Count; i++)
            {
                Console.WriteLine((i + 1).ToString() + " " + eqs[i].Solution() + "\n");
            }


            int action = 0;
            Console.WriteLine("Enter 1 for Equation to number and back");
            while (!int.TryParse(Console.ReadLine(), out action)) ;
            if (action != 1)
                return;

            switch (action)
            {

                case 1:
                    {
                        Console.WriteLine($"Coose number 1 to " + (eqs.Count).ToString());
                        int el = 1;

                        while (!int.TryParse(Console.ReadLine(), out el)) ;
                        if (el < 1 || el > (eqs.Count))
                            return;

                        int a = (int)eqs[el - 1];

                        Console.WriteLine("int a from equation  =  " + a.ToString());

                        eqs[el - 1] = (Quadratic_equation)a;

                        Console.WriteLine("Equation back from a:    " + eqs[el - 1].ToString());

                        Console.ReadKey();

                        break;
                    }
            }
        }
    }
}