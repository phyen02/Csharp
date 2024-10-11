/*
Thực hiện chuẩn hoá một chuỗi họ tên của người dùng với các yêu cầu:
- Cho nhập vào một chuỗi
- In ra chuỗi đó với các yêu cầu sau:
    + Cắt bỏ hết các khoảng trắng dư ở đầu cuối chuỗi.
    + Các từ cách nhau một khoảng trắng nếu phát hiện có nhiều hơn 1 khoảng trắng thì thực hiện cắt bỏ.
    + Viết hoa chữ cái đầu tiên của mỗi từ, các chữ cái tiếp theo thì viết thường.
*/
using System;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            string fullNameRaw;
            string fullName = "";

            Console.WriteLine("Input your name here: ");
            fullNameRaw = Console.ReadLine();

            // String format
            fullNameRaw = fullNameRaw.Trim();
            while (fullNameRaw.IndexOf("  ") != -1)
            {
                fullNameRaw = fullNameRaw.Replace("  ", " ");
            }

            string[] splitName = fullNameRaw.Split(' ');
            for (int i = 0; i < splitName.Length; i++)
            {
                string firstName = splitName[i].Substring(0,1);
                string lastName = splitName[i].Substring(1);
                splitName[i] = firstName.ToUpper() + lastName.ToLower();
                fullName += splitName[i] + " ";
            }

            fullName = fullName.Trim();

            Console.WriteLine("Name: " + fullName);
        }
    }
}