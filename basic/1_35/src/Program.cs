/*
Cho một mảng các số nguyên n phần tử arr.
Hãy viết chương trình sắp xếp các phần tử của mảng theo thứ tự tăng dần
và hiển thị ra màn hình mảng sau khi đã sắp xếp.
*/

using System.Runtime.CompilerServices;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong mang: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Mang sap xep tang dan");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }
}