/*
Cho một mảng các số nguyên n phần tử. Hãy viết chương trình in ra các số trong khoảng [n..1]
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] reverse = ReverseArr(5);
            for (int i = 0; i < 5; i++)
            {
                Console.Write(reverse[i]);
            }
        }

        public static int[] ReverseArr(int n)
        {
            int[] arr = new int[n];

            for (int i = 0, num = n; i < n; i++, num--)
            {
                arr[i] = num;
            }
            return arr;
        }
    }
}