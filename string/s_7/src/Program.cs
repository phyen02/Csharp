/*
Cho xâu s được nhập và từ bàn phím, bạn hãy viết chương trình đảo ngược xâu s và hiển thị ra màn hình.
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.Write("Use reverse function: ");
            way1(s);
            Console.Write("Use for loop: ");
            way2(s);
        }

        static void way1(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string sRev = new string(arr);
            Console.WriteLine(sRev);
        }

        static void way2(string s)
        {
            for (int i = s.Length-1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}