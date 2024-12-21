/*
Viết một hàm tạo tên viết tắt, lấy chữ cái đầu tiên của tên, cách nhau bằng dấu chấm và in hoa tất cả chữ
**Ví dụ:** “Sam Harris” → S.H
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string abbrev = AbbrevName(name);
            Console.WriteLine(abbrev);
        }

        public static string AbbrevName(string name)
        {
            string[] splitName = name.Split(' ');
            if (name.Length > 0)
            {
                return (splitName[0][0] + "." + splitName[1][0]).ToUpper();
            }
            return "";
        }
    }
}