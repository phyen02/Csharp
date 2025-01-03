/*
Tạo một hàm lấy số nguyên không âm làm đối số và trả về số đó cùng với các chữ số theo thứ tự giảm dần.
Về cơ bản, sắp xếp lại các chữ số để tạo ra số cao nhất có thể.
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DescNum(25295));
        }

        public static int DescNum(int n)
        {
            return int.Parse(new string(n.ToString().OrderByDescending(c => c).ToArray()));
        }
    }
}