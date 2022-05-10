using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Quadratic_equation
    {
        private int a, b, c;
        public int A { get { return a; } set { a = value; } }
        public int B { get { return b; } set { b = value; } }
        public int C { get { return c; } set { c = value; } }

        public Quadratic_equation() { }
        public Quadratic_equation(int value)
        {
            a = value;
            b = c = 0;
        }
        public Quadratic_equation(int value_1, int value_2)
        {
            a = value_1;
            b = value_2;
            c = 0;
        }
        public Quadratic_equation(int value_1, int value_2, int value_3)
        {
            a = value_1;
            b = value_2;
            c = value_3;
        }

        public static Quadratic_equation operator+(Quadratic_equation eq, int value)
        {
            eq.C += value;
            return eq;
        }
        public static Quadratic_equation operator-(Quadratic_equation eq, int value)
        {
            eq.C -= value;
            return eq;
        }

        public static Quadratic_equation operator+(Quadratic_equation eq_1, Quadratic_equation eq_2)
        {
            eq_1.A += eq_2.A;
            eq_1.B += eq_2.B;
            eq_1.C += eq_2.C;
            return eq_1;
        }
        public static Quadratic_equation operator -(Quadratic_equation eq_1, Quadratic_equation eq_2)
        {
            eq_1.A -= eq_2.A;
            eq_1.B -= eq_2.B;
            eq_1.C -= eq_2.C;
            return eq_1;
        }
        public static Quadratic_equation operator ++(Quadratic_equation eq)
        {
            eq.C++;
            return eq;
        }
        public static Quadratic_equation operator --(Quadratic_equation eq)
        {
            eq.C--;
            return eq;
        }
        public static Quadratic_equation operator*(Quadratic_equation eq, int value )
        {
            eq.A *= value;
            eq.B *= value;
            eq.C *= value;
            return eq;
        }
        public static Quadratic_equation operator /(Quadratic_equation eq, int value)
        {
            eq.A /= value;
            eq.B /= value;
            eq.C /= value;
            return eq;
        }
        public static explicit operator double(Quadratic_equation eq)
        {
            return eq.A;
        }
        public static explicit operator Quadratic_equation(int v)
        {
            return new Quadratic_equation(v, v, v);
        }
        public static bool operator true(Quadratic_equation eq) => eq.B * eq.B - 4 * eq.A * eq.C >= 0;
        public static bool operator false(Quadratic_equation eq) => eq.B - 4 * eq.A * eq.C < 0;

        public static bool operator ==(Quadratic_equation eq_1, Quadratic_equation eq_2)
        {
            return (eq_1.A == eq_1.A && eq_1.B == eq_2.B && eq_2.C == eq_1.C);
        }

        public static bool operator !=(Quadratic_equation eq_1, Quadratic_equation eq_2)
        {
            return (eq_1.A != eq_1.A || eq_1.B != eq_2.B || eq_2.C != eq_1.C);
        }

        public new string ToString()
        {
            string str = "";

            if (a != 0)            
                str += a.ToString() + "x^2 ";
            else
                str = "0";

            if (b != 0 && b > 0)
                str += "+ " + b.ToString() + "x ";

            else if (b != 0 && b < 0) 
                str += "- " + (-b).ToString() + "x ";
            
            if (c != 0 && c > 0) 
                str += "+ " + c.ToString();
            
            else if (c != 0 && c < 0) 
                str += "- " + (-c).ToString();

            if (str == "")
                str = "0x^2 + 0x + 0";
            return str;
        }

        public string Solution()
        {
            string str = "";

            if (a==0 && b==0 && c == 0)
                str = "Equation: " + this.ToString() + "\nhas infinity of roots";
            if (a!=0 && b!=0 && c==0)
                str = "Equation: " + this.ToString() + "\nroot 1: 0\nroot 2: " + (-b * 1.0 / a).ToString();
            if (a != 0 && c != 0 && b == 0)
            {
                if (-c * 1.0 / a > 0)
                    str = "Equation: " + this.ToString() + "\nroot 1: " + Math.Sqrt(-c * 1.0 / a).ToString()
                    + "\nroot 2: -" + Math.Sqrt(-c * 1.0 / a).ToString();
                else 
                    str = "Equation: " + this.ToString() + " \nhas no roots";
            }

            if (a == 0 && b != 0 && c != 0) 
                str = "Equation: " + this.ToString() + "\nroot: " + (-c * 1.0 / b).ToString();
           
            if ((a != 0 && b == 0 && c == 0) || (a == 0 && b != 0 && c == 0))
                str = "Equation: " + this.ToString() + "\nroot: 0";

            if (a == 0 && b == 0 && c != 0)
                str = "Equation: " + this.ToString() + " \nhas no roots";

            if (a != 0 && b != 0 && c != 0)
            {
                double D = b * b - 4 * a * c;
                if (D < 0)
                    str = "Equation: " + this.ToString() + " \nhas no roots";
                
                else if (D == 0) 
                    str = "Equation: " + this.ToString() + "\nroot: " + (-b * 1.0 / (2 * a)).ToString();

                else if (D > 0)
                    str = "Equation: " + this.ToString() + "\nroot 1: " + ((-b + Math.Sqrt(D)) / (2 * a)).ToString()
                    + "\nroot 2: " + ((-b - Math.Sqrt(D)) / (2 * a)).ToString();
            }

            return str;
        }

    }
}
