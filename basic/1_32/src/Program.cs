/*
 Cho số nguyên n được nhập từ bàn phím, bạn hãy viết phương thức đệ quy trả về tổng các số lẻ từ 1 tới n.
*/


namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(n));
        }

        public static int Sum(int n)
        {
            if (n == 1) return 1;
            if (n % 2 == 0)
                return Sum(n - 1);
            else
                return n + Sum(n-1);
        }
    }
}