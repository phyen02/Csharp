/*Nhập vào tuần tự ngày tháng năm và xuất ra ngày trước ngày vừa nhập.*/

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
                DateTime prevDate = dt.AddDays(-1);
                
                Console.WriteLine("Day: " + dt.ToShortDateString());
                Console.WriteLine("Previous day: " + prevDate.ToShortDateString());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Date format error. Please try again");
                goto inputDate;
            }
        }
    }
}