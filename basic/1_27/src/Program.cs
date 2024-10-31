/*
    Kiểm tra số n có phải số đối xứng hay không?
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

            if (checkSymmetricalNumb(n))
            {
                Console.WriteLine("{0} is symmetrical number", n);
            }
            else
            {
                Console.WriteLine("{0} is not symmetrical number", n);
            }
        }

        static bool checkSymmetricalNumb(int n){ return n == reverseNumb(n); }

        static int reverseNumb(int n)
        {
            int lastNumb;
            int reverseNumb = 0;
            while (n != 0)
            {
                lastNumb = n % 10;
                reverseNumb = reverseNumb*10 + lastNumb;
                n /= 10;
            }
            return reverseNumb;
        }
    }
}