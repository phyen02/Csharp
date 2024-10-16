/*
    Viết chương trình nhập vào số n và kiểm tra xem n có phải số nguyên tố hay không?
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

            if (checkPrimeNumb(n))
            {
                Console.WriteLine("{0} la so nguyen to", n);
            }
            else
            {
                Console.WriteLine("{0} khong la so nguyen to", n);
            }

        }

        static void listPrime(int n)
        {
            int count = 0;
            for (int i = 2; i <= n; i++)
            {
                if (checkPrimeNumb(i))
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine("\nCount: " + count);
        }

        static bool checkPrimeNumb(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else if (n == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}