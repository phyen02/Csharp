/*
Nhập vào năm, kiểm tra xem năm đó có phải năm nhuận hay không?
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int year;
            Console.WriteLine("CHECK LEAP YEAR SYSTEM");
            Console.Write("Year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("{0} is leap year", year);
            } else
            {
                Console.WriteLine("{0} is not leap year", year);
            }
        }
    }
}