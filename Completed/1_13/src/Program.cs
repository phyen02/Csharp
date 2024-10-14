/* Viết phương trình bậc 2 ax^2 + bx + c = 0 */
namespace Program
{
    class System
    {
        public static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("ax^2 + bx + c = 0");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------");
            //UseIf(a, b, c);
            UseSwitch(a, b, c);
        }

        static void UseIf(double a, double b, double c)
        {
            double delta;
            double x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co mot nghiem x = " + (-c / b));
                }
            }
            else if (a != 0)
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                if (delta > 0)
                {
                    Console.WriteLine("delta = " + delta);
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = " + Math.Round(x1, 3));
                    Console.WriteLine("x2 = " + Math.Round(x2, 3));
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + (-b / (2 * a)));
                }
                else
                {
                    Console.Write("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Loi khong xac dinh");
            }
        }

        static void UseSwitch(double a, double b, double c)
        {
            double delta;
            double x1, x2;

            switch (a)
            {
                case <= 0:
                    if (b == 0)
                    {
                        Console.Write("Phuong trinh vo nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh co mot nghiem x = " + (-c / b));
                    }
                    break;
                case > 0:
                    delta = Math.Pow(b, 2) - 4 * a * c;
                    switch (delta)
                    {
                        case < 0:
                            Console.Write("Phuong trinh vo nghiem");
                            break;
                        case > 0:
                            Console.WriteLine("delta = " + delta);
                            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                            x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                            Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                            Console.WriteLine("x1 = " + Math.Round(x1, 3));
                            Console.WriteLine("x2 = " + Math.Round(x2, 3));
                            break;
                        default:
                            Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + (-b / (2 * a)));
                            break;
                    }
                    break;
                default:
                    Console.Write("Loi chua xac dinh");
                    break;
            }
        }
    }
}