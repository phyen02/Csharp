/*
In ra 1 ma trận số cho trước và 1 ma trận số ngẫu nhiên
Dùng while và do-while
*/

using System;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int choose = -1;
            do
            {
                Console.WriteLine("-----CREATE MATRIX-----");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create matrix manual");
                Console.WriteLine("2. Create matrix automatic");
                Console.WriteLine("-----------------------");
                Console.Write("Your option: ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Matrix();
                        break;
                    case 2:
                        MatrixRandom();
                        break;
                    default: break;
                }
            } while (choose != 0);
        }

        static void Matrix()
        {
            int rows, cols;
            Console.Write("Input quantity of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input quantity of columns: ");
            cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Input value for matrix");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Input value for a[{0},{1}]: ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix created");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.Write("\n");
            }
        }

        static void MatrixRandom()
        {
            int rows, cols;
            int range;
            Console.WriteLine("Please insert range to create random quantity of row and column");
            Console.Write("Max range: ");
            range = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            rows = random.Next(1, range);
            cols = random.Next(1, range);
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 20);
                }
            }

            Console.WriteLine("Matrix created");
            Console.WriteLine("Rows: " + rows);
            Console.WriteLine("Columns: " + cols);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                Console.Write("\n");
            }
        }
    }
}
