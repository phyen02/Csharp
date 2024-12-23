/*
Xoá các nguyên âm trong chuỗi có sẵn, trả về chuỗi đã xoá nguyên âm
Ví dụ: "This website is for losers LOL!" → "Ths wbst s fr lsrs LL!”
*/
using System.Text.RegularExpressions;

namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string comment = "This website is for losers LOL!";
            Console.WriteLine(comment.RemoveVowel());
        }

        public static string RemoveVowel(this string comment)
        {
            return Regex.Replace(comment ,"[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}