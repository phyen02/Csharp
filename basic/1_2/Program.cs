/*
    Viết chương trình nhập vào các thông tin: Tên, Tuổi, Địa chỉ
    Xuất ra màn hình theo định dạng: Bạn tên <Tên>, <Tuổi> tuổi, ở <Địa chỉ>
*/
using System;

namespace System{
    public class Program{
        public static void Main(string[] args)
        {
            String name;
            int age;
            String address;

            Console.WriteLine("PLEASE WRITE DOWN INFORMATION");
            Console.Write("Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Address: ");
            address = Convert.ToString(Console.ReadLine());

            Console.WriteLine("CONTACT INFORMATION");
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You're {0} years old", age);
            Console.WriteLine("You're live in " + address);
        }
    }
}