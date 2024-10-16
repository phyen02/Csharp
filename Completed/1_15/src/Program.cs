/*
    Nhập vào tuần tự ngày, tháng , năm và xuất ra thứ của ngày đó trong tuần
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int date, month, year;

        inputDate:
            try
            {
                Console.Write("Date: ");
                date = Convert.ToInt32(Console.ReadLine());
                Console.Write("Month: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Year: ");
                year = Convert.ToInt32(Console.ReadLine());
                DateTime dt = new DateTime(year, month, date);
                Console.WriteLine("Day: " + dt.DayOfWeek.ToString());
            }
            catch
            {
                Console.WriteLine("Date format error. Please try again!");
                goto inputDate;
            }
        }
    }
}