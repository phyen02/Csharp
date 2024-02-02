/*
- Viết chương trình nhập vào 2 số A và B
- Tính tổng, hiệu, tích, thương của A và B
- Ép kiểu strA, strB về số nguyên
*/
using System;

namespace System{
    class Program{
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            string? strA, strB;

            Console.Write("Please input A number: ");
            strA = Console.ReadLine();
            Console.Write("Please input B number: ");
            strB = Console.ReadLine();

            a = Int32.Parse(strA);
            b = Int32.Parse(strB);

            int sum = a + b;
            int minus = a - b;
            int multi = a * b;
            double divide = (double) a / b;
            Console.WriteLine("--------");
            Console.WriteLine("Sum of A and B: " + sum);
            Console.WriteLine("Minus of A and B: " + minus);
            Console.WriteLine("Multiply of A and B: " + multi);
            Console.WriteLine("Dividual of A and B: " + divide);
        }
    }
}