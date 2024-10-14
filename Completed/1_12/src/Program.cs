/*
Nhập vào 2 giá trị kiểu số a và b. Xuất ra màn hình kết quả so sánh:
a > b
a < b
a >= b
a <= b
a == b
a != b
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.Write("Input value a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input value b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a > b -> " + (a > b));
            Console.WriteLine("a < b -> " + (a < b));
            Console.WriteLine("a >= b -> " + (a >= b));
            Console.WriteLine("a <= b -> " + (a <= b));
            Console.WriteLine("a == b -> " + (a == b));
            Console.WriteLine("a != b -> " + (a != b));
        }
    }
}