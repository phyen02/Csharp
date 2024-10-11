/*
    Vẽ hình bằng for, while
    1. Hình vuông
    2. Hình tam giác
    3. Hình tròn
*/

using System;
using System.ComponentModel.DataAnnotations;

namespace System{
    class Program{
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int choose = -1;

            Console.WriteLine("------------------------------");
            Console.WriteLine("     Drawing Program     ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Square use For Loop");
            Console.WriteLine("2. Square use While Loop");
            Console.WriteLine("3. Circle use For Loop");
            Console.WriteLine("4. Circle use While Loop");
            Console.WriteLine("5. Rectangle use For Loop");
            Console.WriteLine("6. Rectangle use While Loop");
            Console.WriteLine("------------------------------");
            Console.Write("Your option: ");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 0: break;
                case 1:
                    DrawSquareFor();
                    break;
                case 2:
                    DrawSquareWhile();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default: break;
            }
        }
        static void DrawSquareFor()
        {
            string symbol = "* ";
            string space = "  ";
            int length = 10;
            int width = 30;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i % (length-1) == 0) || (j % (width-1) == 0))
                    {
                        Console.Write(symbol);
                    } else
                        {
                            Console.Write(space);
                        }
                }
                Console.Write("\n");
            }
        }

        static void DrawSquareWhile()
        {

        }
    }
}