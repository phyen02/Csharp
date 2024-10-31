/*
Viết chương trình lưu trữ thông tin của sinh viên bao gồm:
    mã số, họ tên, điểm toán, điểm lý, điểm văn.
Thực hiện nhập thông tin cho 1 sinh viên và tính điểm trung bình theo công thức (toán + lý + văn)/3.
*/

using System;

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();

            Console.WriteLine("STUDENT STUDY PROGRESS DATA ENTRY");
            InsertInfo(out sv);
            Console.WriteLine("\nSTUDENT STUDY PROGRESS");
            OutputInfo(sv);
        }

        struct SinhVien
        {
            public int UID;
            public string fName;
            public double pMath;
            public double pPhy;
            public double pLite;
        }

        static void InsertInfo(out SinhVien sv)
        {
            Console.WriteLine("Insert UID: ");
            sv.UID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert name: ");
            sv.fName = Console.ReadLine();
            Console.WriteLine("Math: ");
            sv.pMath = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Physics: ");
            sv.pPhy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Literature: ");
            sv.pLite = Convert.ToDouble(Console.ReadLine());
        }

        static void OutputInfo(SinhVien sv)
        {
            Console.WriteLine("UID: " + sv.UID);
            Console.WriteLine("Full name: " + sv.fName);
            Console.WriteLine("Math: " + sv.pMath);
            Console.WriteLine("Physics: " + sv.pPhy);
            Console.WriteLine("Literature: " + sv.pLite);
            Console.WriteLine("Average mark: " + Math.Round(Average(sv), 2));
        }

        static double Average(SinhVien sv)
        {
            return (sv.pMath + sv.pPhy + sv.pLite) / 3;
        }
    }
}