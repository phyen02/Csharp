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
            // int choose = -1;

            // Console.WriteLine("-------------------------");
            // Console.WriteLine("-----Drawing Program-----");
            // Console.WriteLine("1. Square");
            // Console.WriteLine("2. Circle");
            // Console.WriteLine("3. Rectangle");
            // Console.WriteLine("-------------------------");
            // Console.Write("Your option: ");
            // choose = Convert.ToInt32(Console.ReadLine());

            // switch (choose)
            // {
            //     case 0: break;
            //     case 1:
            //         break;
            //     case 2:
            //         break;
            //     case 3:
            //         break;
            //     default: break;
            // }

            square_for();
        }

        static void square_for()
        {
            char symbol = '*';
            char space = ' ';
            int length = 20;
            int width = 20;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if ((i % (length-1) == 0 || j % (width-1) == 0))
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
    }
}