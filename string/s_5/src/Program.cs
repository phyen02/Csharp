/*
Cho xâu s được nhập vào từ bàn phím, hãy viết chương trình hiển thị
ra màn hình những ký tự không phải là số trong xâu s.
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for(char c = '0'; c <= '9'; c++)
            {
                s = s.Replace(c + "", "");
            }
            Console.WriteLine(s);
        }
    }
}