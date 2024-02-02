/*
    Viết chương trình nhập vào các thông tin: Tên, Tuổi, Địa chỉ
    Xuất ra màn hình theo định dạng: Bạn tên <Tên>, <Tuổi> tuổi, ở <Địa chỉ>
*/
using System;

namespace System{
    public class Program{
        public static void Main(string[] args)
        {
            Console.Write("Name: ");
            Console.WriteLine("Your name is " + Console.ReadLine());
            Console.Write("Your age: ");
            Console.WriteLine("You're {0} years old", Console.ReadLine());
            Console.Write("Address: ");
            Console.WriteLine("You're live in " + Console.ReadLine());
        }
    }
}