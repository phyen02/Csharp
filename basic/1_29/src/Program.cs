/*
    Cho người dùng nhập vào 2 số và kiểm tra xem có số nào là số con của số còn lại không?
*/

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b;
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("a va b la chuoi con cua nhau");
            }
            else if (checkSubset(a, b))
            {
                Console.WriteLine("b la chuoi con cua a");
            }
            else if (checkSubset(b, a))
            {
                Console.WriteLine("a la chuoi con cua b");
            }
            else
            {
                Console.WriteLine("a va b khong la chuoi con cua nhau");
            }
        }

        static bool checkSubset(int a, int b)
        {
            string sMax = Convert.ToString(a);
            string sMin = Convert.ToString(b);

            int resetMin = 0;
            for (int i = 0; i < sMax.Length; i++)
            {
                if (sMax[i] == sMin[resetMin])
                {
                    resetMin++;
                    if (resetMin == sMin.Length)
                    {
                        return true;
                    }
                }
                else
                {
                    resetMin = 0;
                }
            }
            return false;
        }
    }
}