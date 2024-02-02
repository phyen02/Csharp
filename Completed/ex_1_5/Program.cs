/* Viết chương trình nhập vào một số tương ứng là năm.
    - Xuất ra màn hình năm vừa nhập và tuổi của một người tương ứng với năm vừa nhập đó.
    - Nếu tuổi người đó < 16 thì hiện thông báo theo format:
    Bạn <Tuổi>, tuổi vị thành niên.
    - Nếu tuổi người đó >= 16 và <18 thì hiện thông báo theo format:
    Bạn <Tuổi>, tuổi trưởng thành.
    - Nếu tuổi người đó >= 18 thì hiện thông báo theo format:
    Bạn <Tuổi>, già rồi.
Yêu cầu: Dùng if-else
*/

using System;

namespace System{
    class Program{
        public static void Main(string[] args)
        {
            int year = 0;
            int systemYear = DateTime.Now.Year;
            int age = 0;

            Console.Write("Input year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year < systemYear){
                age = systemYear - year;
                Console.WriteLine("Year: " + year);
                Console.WriteLine("Age: " + age);
                if (age < 16){
                    Console.WriteLine("You are {0}, teenager", age);
                } else if (age < 18){
                    Console.WriteLine("You are {0}, adult", age);
                } else {
                    Console.WriteLine("You are {0}, older now", age);
                }
            } else {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}