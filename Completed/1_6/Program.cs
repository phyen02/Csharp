/* Viết chương trình nhập vào một số tương ứng là năm.
    Xuất ra màn hình năm vừa nhập và tuổi của một người tương ứng với năm vừa nhập đó.
        - Nếu tuổi người đó < 16 thì hiện thông báo theo format:
            Bạn <Tuổi>, tuổi vị thành niên.
        - Nếu tuổi người đó >= 16 và <18 thì hiện thông báo theo format:
            Bạn <Tuổi>, tuổi trưởng thành.
        - Nếu tuổi người đó >= 18 thì hiện thông báo theo format:
            Bạn <Tuổi>, già rồi.
    **Yêu cầu:** Dùng switch-case
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

            if(year <= systemYear){
                age = systemYear - year;
                Console.WriteLine("Year: " + year);
                Console.WriteLine("Age: " + age);
                switch (age){
                case <16:
                    Console.WriteLine("You're {0}, teenager", age);
                    break;
                case <18:
                    Console.WriteLine("You're {0}, adult", age);
                    break;
                default:
                    Console.WriteLine("You're {0}, very old", age);
                    break;
                }
            } else{
                Console.Write("Something went wrong");
            }
        }
    }
}