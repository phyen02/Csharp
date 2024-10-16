/*
Tính kết quả của các phương trình với x nhập từ bàn phím
- S = 1/x + 2/x + 3/x + … + x/x
- S = x^1 + x^2 + … + x^x
- S = (x)*(x - 1)*(x - 2)*…*(1)
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());

            Equation_1(x);
            Equation_2(x);
            Equation_3(x);
        }

        static void Equation_1(int x)
        {
            // S = 1/x + 2/x + 3/x + … + x/x
        }

        static void Equation_2(int x)
        {
            // S = x^1 + x^2 + … + x^x
        }

        static void Equation_3(int x)
        {
            // S = (x)*(x - 1)*(x - 2)*…*(1)
        }
    }
}