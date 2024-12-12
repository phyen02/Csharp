using System;
using System.ComponentModel.Design;
using System.Reflection;

#pragma warning disable CS8604
#pragma warning disable CS8600

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
                Console.WriteLine("4. Search by name");
                Console.WriteLine("5. Sort by GPA");
                Console.WriteLine("6. Sort by name");
                Console.WriteLine("7. Sort by ID");
                Console.WriteLine("8. Students list");
                Console.WriteLine("0. Exit program");
                Console.WriteLine("--------------------------------");
                Console.Write("Action: ");
                opt = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");

                int SID;
                switch (opt)
                {
                    case 0:
                        break;
                    case 1:
                        st.AddStudent();
                        break;
                    case 2:
                        if (st.CountStudents() > 0)
                        {
                            Console.Write("Student's ID: ");
                            SID = int.Parse(Console.ReadLine());
                            st.UpdateStudent(SID);
                        }
                        else
                        {
                            Console.WriteLine("Empty student list");
                        }
                        break;
                    case 3:
                        if (st.CountStudents() > 0)
                        {
                            Console.Write("Student's ID: ");
                            SID = int.Parse(Console.ReadLine());
                            if (st.DeleteByID(SID))
                            {
                                Console.WriteLine("Delete Successfull");
                            }
                            else
                            {
                                Console.WriteLine("Can't excute, please try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Empty student list");
                        }
                        break;
                    case 4:
                        if (st.CountStudents() > 0)
                        {
                            string name;
                            Console.Write("Student's name: ");
                            name = Console.ReadLine();
                            st.SearchByName(name);
                            st.StudentInfo(st);
                        }
                        break;
                    case 5:
                        st.SortByGPA();
                        st.StudentInfo(st);
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
        public int SID;
        public string? Name;
        public int Age;
        public string? Gender;
        public double pMath;
        public double pPhy;
        public double pChe;

        public double getPChe()
        {
            return this.pChe;
        }

        public void setPChe(double pChe)
        {
            this.pChe = pChe;
        }

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

        public double GPA() { return Math.Round((pMath + pPhy + pChe) / 3, 3); }

        public void Criteria(double ave)
        {
            Console.Write("Perfomance: ");
            if (ave >= 8) { Console.WriteLine("Excellent"); }
            else if (ave >= 6.5) { Console.WriteLine("Good"); }
            else if (ave >= 5) { Console.WriteLine("Average"); }
            else { Console.WriteLine("Weak"); }
        }
    }

    class ManageStudent : Student
    {
        private List<Student> studentList = new List<Student>();

        private int GenerateID()
        {
            int max = 1;
            if (studentList != null && studentList.Count > 0)
            {
                int sid = studentList[0].SID;
                foreach (Student st in studentList)
                {
                    if (max < sid)
                    {
                        max = sid;
                    }
                    max++;
                }
            }
            return max;
        }

        public int CountStudents()
        {
            if (studentList != null)
                return studentList.Count;
            return 0;
        }

        public void StudentInfo(Student st)
        {
            Console.WriteLine("SID: " + st.SID);
            Console.WriteLine("Name: " + st.Name);
            Console.WriteLine("Age: " + st.Age);
            Console.WriteLine("Gender: " + st.Gender);
            Console.WriteLine("Math point: " + st.pMath);
            Console.WriteLine("Physic point: " + st.pPhy);
            Console.WriteLine("Chemistry point: " + st.pChe);
            double ave = GPA();
            Console.WriteLine("GPA: " + ave);
            Criteria(ave);
        }

        public void AddStudent()
        {
            Student st = new Student();

            st.SID = GenerateID();
            Console.WriteLine("SID: " + st.SID);

            Console.Write("Name: ");
            st.Name = Console.ReadLine();

            Console.Write("Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Gender: ");
            Gender = Console.ReadLine();

        EnterMScore:
            Console.WriteLine("Enter score >= 0 and <= 10");
            Console.Write("Math point: ");
            double _pMath = double.Parse(Console.ReadLine());
            if (_pMath >= 0 && _pMath <= 10)
                pMath = _pMath;
            else
                goto EnterMScore;

            EnterPScore:
            Console.Write("Physic point: ");
            double _pPhy = double.Parse(Console.ReadLine());
            if (_pPhy >= 0 && _pPhy <= 10)
                pPhy = _pPhy;
            else
                goto EnterPScore;

            EnterCScore:
            Console.Write("Chemistry point: ");
            double _pChe = double.Parse(Console.ReadLine());
            if (_pChe >= 0 && _pChe <= 10)
                pChe = _pChe;
            else
                goto EnterCScore;

            double ave = GPA();
            Console.WriteLine("GPA: " + ave);
            Criteria(ave);

            studentList.Add(st);
        }

        public void UpdateStudent(int SID)
        {
            Student st = FindByID(SID);
            if (st != null)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name != null && name.Length > 0)
                {
                    st.Name = name;
                }

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                if (age > 0)
                    st.Age = age;

                Console.Write("Gender: ");
                string gender = Console.ReadLine();
                if (gender != null && gender.Length > 0)
                    st.Gender = gender;

                Console.Write("Math point: ");
                double pM = double.Parse(Console.ReadLine());
                if (pM >= 0 && pM <= 10)
                    st.pMath = pM;

                Console.Write("Physic point: ");
                double pP = double.Parse(Console.ReadLine());
                if (pP >= 0 && pP <= 10)
                    st.pPhy = pP;

                Console.Write("Chemistry point: ");
                double pC = double.Parse(Console.ReadLine());
                if (pC >= 0 && pC <= 10)
                    st.pMath = pC;

                Console.WriteLine("\n-----------\nModify success!");
            }
            else
            {
                Console.WriteLine("No student information");
            }
        }
        public Student FindByID(int SID)
        {
            Student result = null;
            if (studentList != null && studentList.Count > 0)
            {
                foreach (Student st in studentList)
                {
                    if (st.SID == SID)
                    {
                        result = st;
                    }
                }
            }
            return result;
        }

        public bool DeleteByID(int SID)
        {
            bool isDelete = false;
            Student st = FindByID(SID);
            if (st != null)
            {
                isDelete = studentList.Remove(st);
            }
            return isDelete;
        }

        public List<Student> SearchByName(string keyword)
        {
            List<Student> searchResult = new List<Student>();
            if (studentList != null && studentList.Count > 0)
            {
                foreach (Student st in studentList)
                {
                    if (st.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(st);
                    }
                }
            }
            return searchResult;
        }

        public void SortByGPA()
        {
            studentList.Sort(delegate (Student st1, Student st2)
            {
                double gpa1 = st1.GPA();
                double gpa2 = st2.GPA();

                return gpa1.CompareTo(gpa2);
            });
        }
    }
}