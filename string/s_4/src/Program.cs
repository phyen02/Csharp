/*
Cho hai xâu ký tự s1 và s2 được nhập vào từ bàn phím, hãy viết chương trình hiển thị ra
vị trí đầu tiên mà s2 xuất hiện trong s1 (không phân biệt hoa thường).
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            Console.WriteLine(s1.IndexOf(s2));
        }
    }
}