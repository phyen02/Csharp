/*
     Kiểm tra số n có phải số hoàn hảo không
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

            // if (checkPerfectNumb(n))
            // {
            //     Console.WriteLine("{0} is perfect number", n);
            // }
            // else
            // {
            //     Console.WriteLine("{0} is not perfect number", n);
            // }

            Console.WriteLine("List perfect number between 0 and " + n);
            listPerfectNumb(n);
        }

        static bool checkPerfectNumb(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                return true;
            }
            return false;
        }
    
        static void listPerfectNumb(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (checkPerfectNumb(i))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}