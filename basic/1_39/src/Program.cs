/*
Viết chương trình tìm n số Fibonacci đầu tiên trong C#. Số nguyên dương n được nhập từ bàn phím.
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(n)[i] + " ");
            }
        }

        public static int[] Fibonacci(int n)
        {
            int[] fibonacci = new int[n];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
            }

            return fibonacci;
        }
    }
}