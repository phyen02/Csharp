/*
    Viết chương trình cho phép nhập vào một số n và in ra màn hình giá trị [-n..n]
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = -n; i < 0; i++)
            {
                Console.Write(i + " ");
            }

            for (int i = 0; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}