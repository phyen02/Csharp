/*
Viết một hàm lấy một mảng các từ và ghép chúng lại thành một câu và trả về câu đó.
Bạn cần thêm khoảng trắng giữa mỗi từ, không có khoảng trắng ở đầu và cuối câu.
Ví dụ:  ['hello', 'world', 'this', 'is', 'great']  ⇒  'hello world this is great'
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] list = ["hello", "world", "this", "is", "great"];
            Console.Write(Smash(list));
        }

        public static string Smash(string[] words)
        {
            return string.Join(" ", words);
        }
    }
}