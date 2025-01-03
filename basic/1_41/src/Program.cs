/*
Viết một hàm nhận tham số dương num và trả về số lần nhân của nó, là số lần bạn phải
nhân các chữ số trong num cho đến khi đạt đến một chữ số duy nhất.
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Persistence(39));
        }

        public static int Persistence(long n)
        {
            int count = 0;
            while (n > 9)
            {
                n = n.ToString().Select(digits => int.Parse(digits.ToString())).Aggregate((x, y) => x * y);
                count++;
            }
            return count;
        }
    }
}