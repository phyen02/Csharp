/*
 Kiểm tra xem chuỗi có cùng số lượng 'x' và 'o' không. Phương thức này phải trả về
 giá trị boolean và không phân biệt chữ hoa chữ thường. Chuỗi có thể chứa bất kỳ ký tự nào.
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CountXO("xxoo"));
            Console.WriteLine(CountXO("xxooo"));
            Console.WriteLine(CountXO("xSDxodfdxxo"));
             Console.WriteLine(CountXO("Xxoo"));
        }

        public static bool CountXO(string s)
        {
            return s.ToLower().Count(c => c == 'x') == s.ToLower().Count(c => c == 'o');
        }
    }
}