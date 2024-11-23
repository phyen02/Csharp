using System;
using System.ComponentModel.Design;
using System.Reflection;

#pragma warning disable CS8604
#pragma warning disable CS8601

namespace System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu.DisplayMenu();
        }
    }

    class Menu
    {
        public static void DisplayMenu()
        {
            ManageStudent st = new ManageStudent();
            
            int opt = -1;
            while (opt != 0)
            {
                Console.WriteLine("\n-------STUDENT MANAGEMENT-------");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Modify by ID");
                Console.WriteLine("3. Delete by ID");
                Console.WriteLine("4. Search by ID");
                Console.WriteLine("5. Sort by GPA");
                Console.WriteLine("6. Sort by name");
                Console.WriteLine("7. Sort by ID");
                Console.WriteLine("8. Students list");
                Console.WriteLine("0. Exit program");
                Console.WriteLine("--------------------------------");
                Console.Write("Action: ");
                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");
                switch (opt)
                {
                    case 0:
                        break;
                    case 1:
                        st.AddStudent();
                        break;
                    case 2:
                        st.UpdateStudent();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Something goes wrong");
                        break;
                }
            }
        }
    }

    class Student
    {
        protected int SID;
        protected string? Name;
        protected int Age;
        protected string? Gender;
        protected double pMath;
        protected double pPhy;
        protected double pChe;

        public int getSID()
        {
            return this.SID;
        }

        public void setSID(int SID)
        {
            this.SID = SID;
        }

        public string? getName()
        {
            return this.Name;
        }

        public void setName(string? Name)
        {
            this.Name = Name;
        }

        public int getAge()
        {
            return this.Age;
        }

        public void setAge(int Age)
        {
            this.Age = Age;
        }

        public string? getGender()
        {
            return this.Gender;
        }

        public void setGender(string? Gender)
        {
            this.Gender = Gender;
        }

        public double getPMath()
        {
            return this.pMath;
        }

        public void setPMath(double pMath)
        {
            this.pMath = pMath;
        }

        public double getPPhy()
        {
            return this.pPhy;
        }

        public void setPPhy(double pPhy)
        {
            this.pPhy = pPhy;
        }

        public double getPChe()
        {
            return this.pChe;
        }

        public void setPChe(double pChe)
        {
            this.pChe = pChe;
        }


        public double GPA() { return (pMath + pPhy + pChe) / 3; }

    }

    class ManageStudent : Student
    {
        private List<Student>? studentList = null;

        public int GenerateID()
        {
            int max = 1;
            if (studentList != null && studentList.Count > 0)
            {
                if (studentList.Count > max)
                {
                    max = studentList.Count;
                }
                max++;
            }
            return max;
        }

        public void AddStudent()
        {
            GenerateID();

            Console.WriteLine("SID: " + SID);
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            Gender = Console.ReadLine();
            Console.Write("Math point: ");
            pMath = double.Parse(Console.ReadLine());
            Console.Write("Physic point: ");
            pPhy = double.Parse(Console.ReadLine());
            Console.Write("Chemistry point: ");
            pChe = double.Parse(Console.ReadLine());

            double ave = GPA();
            Console.WriteLine("GPA: " + ave);
            Console.Write("Perfomance: ");
            if (ave >= 8) { Console.WriteLine("Excellent"); }
            else if (ave >= 6.5) { Console.WriteLine("Good"); }
            else if (ave >= 5) { Console.WriteLine("Average"); }
            else { Console.WriteLine("Weak"); }
        }

        public void UpdateStudent()
        {

        }
    }
}