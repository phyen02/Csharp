/*
Viết hoa chữ cái đầu của mỗi từ trong chuỗi
Ví dụ: "How can mirrors be real if our eyes aren't real" → "How Can Mirrors Be Real If Our Eyes Aren't Real"
*/

namespace Program
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string str = "Extension methods must be defined";
            Console.WriteLine(str.UpperFirstLetter());
        }

        public static string UpperFirstLetter(this string str)
        {
            string[] sentence = str.Split(' ');

            if (str == null)
            {
                return string.Empty;
            }
            else
            {
                for (int i = 0; i < sentence.Length; i++)
                {
                    sentence[i] = sentence[i][0].ToString().ToUpper() + sentence[i].Substring(1).ToString().ToLower();
                }
            }

            return string.Join(" ", sentence);
        }
    }
}