/*
    Nhập vào tuần tự ngày tháng năm và xuất ra ngày sau ngày vừa nhập.
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

                DateTime dateTime = new DateTime(year, month, date);
                DateTime nextDay = dateTime.AddDays(+1);
                Console.WriteLine("Day: " + dateTime.ToShortDateString());
                Console.WriteLine("Next day: " + nextDay.ToShortDateString());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Date format error. Please try again");
                goto inputDate;
            }
        }
    }
}