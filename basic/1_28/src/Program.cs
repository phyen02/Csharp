/*
    Nhập vào 1 số và xuất ra số phần tử của số đó.
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

            Console.Write("Length: " + checkLength(n));
        }

        static int checkLength(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }
    }
}