/*
    Viết chương trình phép tính của 2 số A và B nhập từ bàn phím.
    Người dùng lựa chọn phép tính trên màn hình menu và nhập vào
    2 số bất kỳ từ bàn phím. In kết quả ra màn hình.
    Phép tính bao gồm: +, -, *, /, %
*/

using System;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choose = -1;
            int val_a = 0;
            int val_b = 0;

            
            // Input variable
            Console.Write("Please input value a: ");
            val_a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input value b: ");
            val_b = Convert.ToInt32(Console.ReadLine());

            do
            {
                // MENU 
                Console.WriteLine("------------ MATH CACULATION PROGRAM ------------");
                Console.WriteLine("--- 0. Exit                                   ---");
                Console.WriteLine("--- 1. Addition                               ---");
                Console.WriteLine("--- 2. Subtraction                            ---");
                Console.WriteLine("--- 3. Multiplication                         ---");
                Console.WriteLine("--- 4. Division                               ---");
                Console.WriteLine("--- 5. Modulus                                ---");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Choose your option: ");
                choose = Convert.ToInt32(Console.ReadLine());
                
                // Caculate each case
                switch (choose)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Result: " + add(val_a, val_b));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + sub(val_a, val_b));
                        break;
                    case 3:
                        Console.WriteLine("Result: " + multi(val_a, val_b));
                        break;
                    case 4:
                        Console.WriteLine("Result: " + division(val_a, val_b));
                        break;
                    case 5:
                        Console.WriteLine("Result: " + modulus(val_a, val_b));
                        break;
                    default:
                        break;
                }
            } while (choose != 0);
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static int sub(int a, int b)
        {
            return a - b;
        }

        static int multi(int a, int b)
        {
            return a * b;
        }

        static double division(int a, int b)
        {
            return (double) a / b;
        }

        static int modulus(int a, int b)
        {
            return a % b;
        }
    }
}