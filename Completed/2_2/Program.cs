// Viết chương trình tính năm âm lịch từ năm dương lịch đã nhập.
/* Phân tích
    - Năm âm lịch = Can + Chi
    - Tính Can bằng cách:
        -> Tìm phần dư của phép chia năm dương lịch cho 10.
        -> Tra bảng Can
    - Tính Chi bằng cách:
        -> Tìm phần dư của phép chia năm dương lịch cho 12.
        -> Tra bảng tìm Chi
*/

using System;
using System.Diagnostics;
using System.Text;

namespace System{
    class Program{
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int calYear = 0;
            int can = 0, chi = 0;

            Console.Write("Input calendar year: ");
            calYear = Convert.ToInt32(Console.ReadLine());

            can = calYear % 10;
            chi = calYear % 12;
            Console.WriteLine("Can: " + can);
            Console.WriteLine("Chi: " + chi);

            Console.Write("Lunar Year: ");
            switch (can){
                case 0:
                    Console.Write("Canh ");
                    break;
                case 1:
                    Console.Write("Tân ");
                    break;
                case 2:
                    Console.Write("Nhâm ");
                    break;
                case 3:
                    Console.Write("Quý ");
                    break;
                case 4:
                    Console.Write("Giáp ");
                    break;
                case 5:
                    Console.Write("Ất ");
                    break;
                case 6:
                    Console.Write("Bính ");
                    break;
                case 7:
                    Console.Write("Đinh ");
                    break;
                case 8:
                    Console.Write("Mậu ");
                    break;
                case 9:
                    Console.Write("Kỷ ");
                    break;
                default:
                    break;
            }

            switch (chi){
                case 0:
                    Console.Write("Thân");
                    break;
                case 1:
                    Console.Write("Dậu");
                    break;
                case 2:
                    Console.Write("Tuất");
                    break;
                case 3:
                    Console.Write("Hợi");
                    break;
                case 4:
                    Console.Write("Tý");
                    break;
                case 5:
                    Console.Write("Sửu");
                    break;
                case 6:
                    Console.Write("Dần");
                    break;
                case 7:
                    Console.Write("Mão");
                    break;
                case 8:
                    Console.Write("Thìn");
                    break;
                case 9:
                    Console.Write("Tỵ");
                    break;
                case 10:
                    Console.Write("Ngọ");
                    break;
                case 11:
                    Console.Write("Mùi");
                    break;
                default:
                    break;
            }
        }
    }
}