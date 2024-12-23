/*
Đếm số lượng các từ nguyên âm có trong chuỗi
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CountVowel("asahduaiasd"));
        }

        public static int CountVowel(string str)
        {
            return str.ToLower().Count(c => "aeiou".IndexOf(c) != -1);
        }
    }
}