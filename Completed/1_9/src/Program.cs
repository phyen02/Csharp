/*
Viết chương trình:
- Cho phép nhập vào giá trị số nguyên cho 1 mảng 2 chiều bất kỳ
- In ra màn hình mảng đã nhập kèm theo tổng tất cả các giá trị trong mảng.
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int row, col;
            int sum = 0;
            Console.Write("Insert quantity of rows: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert quantity of columns: ");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("arr[{0},{1}]: ", i, j);
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("Matrix:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + "   ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i,j];
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}