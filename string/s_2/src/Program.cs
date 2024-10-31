/*
Cho xâu s và ký tự c được nhập từ bàn phím.
Hãy viết chương trình in ra số lần xuất hiện của ký tự c trong xâu s.
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s;
            char c;
            int count = 0;
            s = Console.ReadLine();
            Console.Write("c = ");
            c = char.Parse(Console.ReadLine());
            for (int i = 0; i < s.Length ; i++)
            {
                if (s[i] == c)
                {
                    count++;
                }
            }
            Console.Write(count);
        }
    }
}