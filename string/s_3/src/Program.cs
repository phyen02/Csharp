/*
Cho xâu s và ký tự c được nhập từ bàn phím, hãy viết chương trình in ra
vị trí đầu tiên mà ký tự c xuất hiện trong xâu s, nếu ký tự c không xuất hiện trong s thì in ra -1.
*/

using System.Collections;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s;
            char c;
            int pos = -1;
            
            s = Console.ReadLine();
            c = char.Parse(Console.ReadLine());

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    pos = i;
                    break;
                }
            }

            if (pos > -1)
            {
                Console.WriteLine(pos);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}