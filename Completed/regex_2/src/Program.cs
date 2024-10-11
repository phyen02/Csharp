// Lấy ra chuỗi giờ phút giây có định dạng ‘hour:minute:second'

using System;
using System.Text.RegularExpressions;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Regex reg = new Regex(@"(?<hour>\d+):(?<minute>\d+):(?<second>\d+)");

            foreach (Match item in reg.Matches("10/10/2024 23:11:20 119.60.29.1"))
            {
                Console.WriteLine("Match: " + item.ToString());
                Console.WriteLine("Hour: " + item.Groups["hour"]);
                Console.WriteLine("Minute: " + item.Groups["minute"]);
                Console.WriteLine("Second: " + item.Groups["second"]);
            }
        }
    }
}