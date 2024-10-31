/*
Cho xâu s và số nguyên k được nhập từ bàn phím.
Hãy viết chương trình in ra màn hình ký tự thứ k trong xâu s
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s;
            int k;
            s = Console.ReadLine();
            k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < s.Length; i++)
            {
                if (k == (i+1))
                {
                    Console.WriteLine(s[i]);
                    break;
                }
            }
        }
    }
}