/*
Cho mảng các số nguyên n phần tử arr được nhập từ bàn phím. Hãy viết phương thức đệ quy tính tổng các phần tử của mảng.
*/


namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(SumOfArray(arr, n));
        }

        public static int SumOfArray(int[] arr, int n)
        {
            if (n == 1)
                return arr[0];
            return arr[n - 1] + SumOfArray(arr, n-1);
            
        }
    }
}