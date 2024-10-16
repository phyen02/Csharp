/*
    Kiểm tra số n có phải số chính phương hay không?
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

            if (checkSquareNumb(n))
            {
                Console.WriteLine("{0} is square number", n);
            }
            else
            {
                Console.WriteLine("{0} is not square number", n);
            }

            //listSquareNumb(n);
        }

        static void listSquareNumb(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (checkSquareNumb(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool checkSquareNumb(int n)
        {
            int square = (int)Math.Sqrt(n);
            if (square * square == n)
            {
                return true;
            }
            return false;
        }
    }
}