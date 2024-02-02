/*
    Viết chương trình cho phép người dùng nhập tên của mình
    và hiển thị câu: Duckins Donut xin chào <Tên vừa nhập>.
*/
using System;

namespace System{
    class Program{
        public static void Main(string[] args)
        {
            Console.Write("Your name: ");
            Console.WriteLine("Welcome to Duckins Donut, " + Console.ReadLine());
        }
    }
}