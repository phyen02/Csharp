/*
    Viết chương trình cho phép nhập vào một số n và in ra màn hình số lẻ từ [-n..n]
*/

namespace Program
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
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}