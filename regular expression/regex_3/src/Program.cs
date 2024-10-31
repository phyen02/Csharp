/*
Cho chuỗi sau “10:30:15 IBM 192.168.1.2 INTEL”
Hãy viết biểu thức lấy ra giờ phút giây, địa chỉ ip và tên công ty.
*/

using System;
using System.Text.RegularExpressions;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Regex reg = new Regex(@"(?<time>(\d|:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)");
        
            foreach (Match item in reg.Matches("10:30:15 IBM 192.168.1.2 INTEL"))
            {
                Console.WriteLine("Time: " + item.Groups["time"]);
                Console.Write("Company: ");
                foreach (Capture i in item.Groups["company"].Captures)
                {
                    Console.Write(i.ToString() + " ");
                }
                Console.WriteLine("\nIP: " + item.Groups["ip"]);
            }
        }
    }
}