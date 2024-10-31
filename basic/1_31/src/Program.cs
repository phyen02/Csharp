/*
Cho số nguyên dương n được nhập từ bàn phím, hãy viết phương thức đệ quy trả về n! (n giai thừa).
*/

namespace Program
{
    class Program
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n*(Factorial(n-1));

        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}