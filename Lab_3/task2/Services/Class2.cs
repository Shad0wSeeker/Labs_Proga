using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task2
{
    public static class Class2
    {
        public static void func(double z, double b)
        {
            double y;
            double x;
            
            if (z<1)
            {
                x = z / b;
                y = Math.PI + Math.Pow(Math.Cos(x * x * x), 2) + Math.Pow(Math.Sin(x * x), 3);
                Console.WriteLine(y);
                Console.WriteLine("Вычисление проводилось по первой ветке");
            }

            else if (z>=1)
            {
                x = Math.Sqrt(Math.Pow(z * b, 3));
                y = Math.PI + Math.Pow(Math.Cos(x * x * x), 2) + Math.Pow(Math.Sin(x * x), 3);
                Console.WriteLine(y);
                Console.WriteLine("Вычисление проводилось по второй ветке");
            }
            
        }
    }
}
