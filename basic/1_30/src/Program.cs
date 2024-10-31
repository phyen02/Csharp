/*
Tính kết quả của các phương trình với x nhập từ bàn phím
- S = 1/x + 2/x + 3/x + … + x/x
- S = x^1 + x^2 + … + x^x
- S = (x)*(x - 1)*(x - 2)*…*(1)
*/

using System.Security.Cryptography;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());

            //Equation_1(x);
            //Equation_2(x);
            Equation_3(x);
        }

        static void Equation_1(int x)
        {
            // S = 1/x + 2/x + 3/x + … + x/x
            double sum = 0;
            for (int i = 1; i <= x; i++)
            {
                double frac = (double)i / x;
                sum += frac;
            }
            Console.WriteLine("S1 = " + sum);
        }

        static void Equation_2(int x)
        {
            // S = x^1 + x^2 + … + x^x
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                sum += (int)Math.Pow(x, i);
            }
            Console.WriteLine("S2 = " + sum);
        }

        static void Equation_3(int x)
        {
            // S = (x)*(x - 1)*(x - 2)*…*(1)
            int sum = 0;
            for (int i = 0; i <= x; i++)
            {
                sum += x*(i+1);
            }
            Console.WriteLine("S3 = " + sum);
        }
    }
}