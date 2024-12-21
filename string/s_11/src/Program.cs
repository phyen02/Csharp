/*
Chia chuỗi thành các cặp gồm 2 ký tự, nếu chuỗi là số lẻ thì ký tự cuối cùng thêm “_”
**Ví dụ:** 
'abc' ⇒  ['ab', 'c_']
'abcdef' ⇒ ['ab', 'cd', 'ef']
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "abced";
            string str2 = "abcdwq";
            string[] pairs1 = Solution(str);
            string[] pairs2 = Solution(str2);
            
            for (int i = 0; i < pairs1.Length; i++)
            {
                Console.Write(pairs1[i] + " ");
            }

            Console.WriteLine("");
            for (int i = 0; i < pairs2.Length; i++)
            {
                Console.Write(pairs2[i] + " ");
            }
        }

        public static string[] Solution(string str)
        {
            List<string> pairs = new List<string>();

            if (str.Length % 2 != 0)
            {
                str += "_";
            }

            for (int i = 0; i < str.Length; i+=2)
            {
                pairs.Add(str.Substring(i,2));
            }

            return pairs.ToArray();
        }
    }
}