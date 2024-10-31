// Viết chương trình giải phương trình bậc 1: Ax + B = 0.
/* Phân tích bài
    - Nếu a = 0 -> pt vô số nghiệm
    - Nếu b = 0 -> pt vô nghiệm
    - x = -b / a
*/
using System;

namespace System{
    class Program{
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            double x = 0.0;

            Console.Write("Input a variable: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b variable: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == 0){
                Console.WriteLine("Equation have many roots");
            }
            else if (b == 0){
                    Console.WriteLine("Equation doesn't have root");
            } else {
                x = (double) -b / a;
                Console.WriteLine("Equation has 1 root x = " + x);
            }
        }
    }
}