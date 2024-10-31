/*
Nhập vào 3 số rồi tìm ra giá trị lớn nhất trong 3 số đó
*/

using System.Net;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max value: " + Max(a,b,c));
        }

        static int Max(int a, int b, int c)
        {
            int max = a;
            if (max < b)
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }
            return max;
        }
    }
}