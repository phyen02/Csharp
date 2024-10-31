/*
    Nhập vào một dãy số và tìm phần tử chia hết cho 3 trong mảng đó.
    **Yêu cầu:** Dùng for, while và do/while
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Input max size for array: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\nNumber divisible by 3: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 3 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}