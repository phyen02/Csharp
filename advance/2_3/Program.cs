/* Lập trình chương trình **Máy tính bỏ túi**.
- Hiển thị menu cho phép lựa chọn phép toán.
- Nhập vào số tương ứng để bắt đầu tính toán:
    0. Thoát
    1. Cộng 2 số
    2. Trừ 2 số
    3. Chia nguyên 2 số
    4. Chia dư 2 số
    5. Nhân 2 số
- Khi nhấn chọn giá trị tương ứng sẽ vào cho người dùng nhập vào 2 số và hiển thị kết quả tương ứng.
- Có thể tiếp tục cộng trừ nhân chia từ kết quả vừa tính.
*/
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
            int val_a = 0;
            int val_b = 0;
            int choose = -1;
            int result = 0;
            double dresult = 0.0;
            char cont = 'y';

            do
            {
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

                switch (choose)
                {
                    case 0: break;
                    case 1:
                        Console.Write("Please input value a: ");
                        val_a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please input value b: ");
                        val_b = Convert.ToInt32(Console.ReadLine());
                        result = add(val_a, val_b);
                        Console.WriteLine("Result: " + result);
                        Console.Write("Continue with result? (y/n) ");
                        cont = Convert.ToChar(Console.ReadLine());

                        while (cont != 'n')
                        {
                            val_a = result;
                            result = add(val_a, val_b);
                            Console.WriteLine("Result: " + result);
                            Console.Write("Continue with result? (y/n) ");
                            cont = Convert.ToChar(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.Write("Please input value a: ");
                        val_a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please input value b: ");
                        val_b = Convert.ToInt32(Console.ReadLine());
                        result = sub(val_a, val_b);
                        Console.WriteLine("Result: " + result);
                        Console.Write("Continue with result? (y/n) ");
                        cont = Convert.ToChar(Console.ReadLine());

                        while (cont != 'n')
                        {
                            val_a = result;
                            result = sub(val_a, val_b);
                            Console.WriteLine("Result: " + result);
                            Console.Write("Continue with result? (y/n) ");
                            cont = Convert.ToChar(Console.ReadLine());
                        }
                        break;
                    case 3:
                        Console.Write("Please input value a: ");
                        val_a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please input value b: ");
                        val_b = Convert.ToInt32(Console.ReadLine());
                        result = multi(val_a, val_b);
                        Console.WriteLine("Result: " + result);
                        Console.Write("Continue with result? (y/n) ");
                        cont = Convert.ToChar(Console.ReadLine());

                        while (cont != 'n')
                        {
                            val_a = result;
                            result = multi(val_a, val_b);
                            Console.WriteLine("Result: " + result);
                            Console.Write("Continue with result? (y/n) ");
                            cont = Convert.ToChar(Console.ReadLine());
                        }
                        break;
                    case 4:
                        Console.Write("Please input value a: ");
                        val_a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please input value b: ");
                        val_b = Convert.ToInt32(Console.ReadLine());
                        dresult = division(val_a, val_b);
                        Console.WriteLine("Result: " + (double)dresult);
                        Console.Write("Continue with result? (y/n) ");
                        cont = Convert.ToChar(Console.ReadLine());
                        while (cont != 'n')
                        {
                            val_a = result;
                            dresult = division(val_a, val_b);
                            Console.WriteLine("Result: " + dresult);
                            Console.Write("Continue with result? (y/n) ");
                            cont = Convert.ToChar(Console.ReadLine());
                        }
                        break;
                    case 5:
                        Console.Write("Please input value a: ");
                        val_a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Please input value b: ");
                        val_b = Convert.ToInt32(Console.ReadLine());
                        dresult = modulus(val_a, val_b);
                        Console.WriteLine("Result: " + dresult);
                        Console.Write("Continue with result? (y/n) ");
                        cont = Convert.ToChar(Console.ReadLine());

                        while (cont != 'n')
                        {
                            val_a = result;
                            dresult = modulus(val_a, val_b);
                            Console.WriteLine("Result: " + dresult);
                            Console.Write("Continue with result? (y/n) ");
                            cont = Convert.ToChar(Console.ReadLine());
                        }
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
            return (double)a / b;
        }

        static int modulus(int a, int b)
        {
            return a % b;
        }
    }
}