/*
    Vẽ hình bằng for, while
    1. Hình vuông
    2. Hình tam giác
    3. Hình tròn
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

        static void Test()
        {
            int length = 5;
            int width = 10;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine("i = {0} % = {1} j = {2} % = {3}", i, i % (length - 1), j, j % (width - 1));
                }
            }
        }

        static void Menu()
        {
            int choose = -1;
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("     Drawing Program     ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Draw Square");
                Console.WriteLine("2. Draw Right Triangle");
                Console.WriteLine("3. Draw Right Triangle Reverse");
                Console.WriteLine("4. Equilateral Triangle");
                Console.WriteLine("------------------------------");
                Console.Write("Your option: ");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    //case 0: break;
                    case 1:
                        DrawSquare();
                        break;
                    case 2:
                        DrawRightTriangle();
                        break;
                    case 3:
                        DrawRightTriReverse();
                        break;
                    case 4:
                        DrawEquiTriangle();
                        break;
                    default: break;
                }
            } while (choose != 0);
        }
        static void DrawSquare()
        {
            string symbol = "* ";
            string space = "  ";
            int length = 10;
            int width = 30;

            // For loop
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i % (length - 1) == 0) || (j % (width - 1) == 0))
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(space);
                    }
                }
                Console.Write("\n");
            }

            // While loop
            /*
            int i = 0;
            int j = 0;
            while (i < length)
            {
                while (j < width)
                {
                    if (i % (length - 1) == 0 || j % (width - 1) == 0)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(space);
                    }
                    j++;
                }
                Console.Write("\n");
                i++;
                j = 0;
            }*/
        }
    
        static void DrawRightTriangle()
        {
            int rows = 6;

            // For loop
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // While loop
            /*int i = 1;
            int j = 1;
            while (i <= rows)
            {
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.Write("\n");
                i++;
                j = 1;
            }*/
        }
    
        static void DrawRightTriReverse()
        {
            int rows = 6;
            // For loop
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // While loop
            /*int i = rows;
            int j = 1;
            while (i >= 1)
            {
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.Write("\n");
                i--;
                j = 1;
            }*/
        }
 
        static void DrawEquiTriangle()
        {
            int rows = 6;
            
            // For loop
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
            
            // While loop
            /*int i = 1;
            int j = i;
            int k = 1;
            while (i <= rows)
            {
                while (j < rows)
                {
                    Console.Write(" ");
                    j++;
                }

                while (k <= (2 * i - 1))
                {
                    Console.Write("*");
                    k++;
                }
                Console.Write("\n");
                i++;
                j = i;
                k = 1;
            }*/
        }
    }
}