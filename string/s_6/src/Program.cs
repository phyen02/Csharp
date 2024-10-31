/*
Cho xâu s được nhập vào từ bàn phím, hãy viết chương trình
hiển thị ra màn hình số các ký tự in hoa trong xâu s.
*/
namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}