#pragma warning disable CS8625
#pragma warning disable CS8601
#pragma warning disable CS8600
#pragma warning disable CS8603

namespace StudentManagement
{
    class StudentManage
    {
        private List<Student> studentList = null;

        public StudentManage()
        {
            studentList = new List<Student>();
        }

        public int CountStudent()
        {
            return studentList.Count;
        }
        public void AddStudent()
        {
            Student st = new Student();

            st.SID = GenerateID();
            Console.WriteLine("SID: " + st.SID);

            Console.Write("Name: ");
            st.Name = Console.ReadLine();

            Console.Write("Gender: " + st.Gender);
            st.Gender = Console.ReadLine();

            Console.Write("Age: ");
            st.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input between >=0 and <=10");

            do
            {
                Console.Write("Math: ");
                st.PMath = Convert.ToDouble(Console.ReadLine());
            } while (st.PMath < 0 || st.PMath > 10);

            do
            {
                Console.Write("Physics: ");
                st.PPhysic = Convert.ToDouble(Console.ReadLine());
            } while (st.PPhysic < 0 || st.PPhysic > 10);

            do
            {
                Console.Write("Chemistry: ");
                st.PChemistry = Convert.ToDouble(Console.ReadLine());
            } while (st.PChemistry < 0 || st.PChemistry > 10);

            Console.WriteLine("Average: " + AverageScore(st));

            Evaluate(st);
            Console.WriteLine("Performance: " + st.Perfomance);

            studentList.Add(st);
        }

        public void PrintStudentInfo(List<Student> stList)
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 15}",
                  "ID", "Name", "Gender", "Age", "Math", "Physics", "Chemistry", "Average", "Performance");
            if (stList != null && stList.Count > 0)
            {
                foreach (Student st in stList)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 15}",
                    st.SID, st.Name, st.Gender, st.Age, st.PMath, st.PPhysic, st.PChemistry, st.Average, st.Perfomance);
                }
            }
        }

        public List<Student> getListStudent()
        {
            return studentList;
        }

        private int GenerateID()
        {
            int max = 1;

            if (studentList != null && studentList.Count > 0)
            {
                max = studentList[0].SID;
                foreach (Student st in studentList)
                {
                    if (max < st.SID)
                    {
                        max = st.SID;
                    }
                }
                max++;
            }

            return max;
        }

        public double AverageScore(Student st)
        {
            st.Average = Math.Round((st.PMath + st.PPhysic + st.PChemistry) / 3, 2);
            return st.Average;
        }

        public void Evaluate(Student st)
        {
            if (st.Average >= 8)
            {
                st.Perfomance = "Excellent";
            }
            else if (st.Average >= 6.5)
            {
                st.Perfomance = "Good";
            }
            else if (st.Average >= 5)
            {
                st.Perfomance = "Average";
            }
            else
            {
                st.Perfomance = "Weak";
            }
        }

        public void ModifyStudentByID(int sid)
        {
            Student st = FindByID(sid);

            if (st != null)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (name != null && name.Length > 0)
                {
                    st.Name = name;
                }

                Console.Write("Gender: ");
                string gender = Console.ReadLine();
                if (gender != null && gender.Length > 0)
                {
                    st.Gender = gender;
                }

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age > 0)
                {
                    st.Age = age;
                }

                Console.Write("Math: ");
                double pMath = Convert.ToDouble(Console.ReadLine());
                if (pMath >= 0 && pMath <= 10)
                {
                    st.PMath = pMath;
                }

                Console.Write("Physics: ");
                double pPhy = Convert.ToDouble(Console.ReadLine());
                if (pPhy >= 0 && pPhy <= 10)
                {
                    st.PPhysic = pPhy;
                }

                Console.Write("Chemistry: ");
                double pChe = Convert.ToDouble(Console.ReadLine());
                if (pChe >= 0 && pChe <= 10)
                {
                    st.PChemistry = pChe;
                }

                AverageScore(st);
                Console.WriteLine("Average score: " + st.Average);

                Evaluate(st);
                Console.WriteLine("Performance: " + st.Perfomance);

                Console.Write("\nSuccess modify student...");
            }
            else
            {
                Console.Write("No result");
            }
        }

        public bool DeleteStudentByID(int sid)
        {
            bool isDelete = false;
            Student st = FindByID(sid);
            if (st != null)
            {
                isDelete = studentList.Remove(st);
            }
            return isDelete;
        }

        public Student FindByID(int sid)
        {
            Student result = null;
            if (studentList != null && studentList.Count > 0)
            {
                foreach (Student st in studentList)
                {
                    if (st.SID == sid)
                    {
                        result = st;
                    }
                }
            }
            return result;
        }

        public List<Student> FindByName(string name)
        {
            List<Student> resultList = new List<Student>();

            if (studentList != null && studentList.Count > 0)
            {
                foreach (Student st in studentList)
                {
                    if (st.Name.ToUpper().Contains(name.ToUpper()))
                    {
                        resultList.Add(st);
                    }
                }
            }
            return resultList;
        }

        public void SortByGPA()
        {
            studentList.Sort(delegate (Student st1, Student st2)
            {
                return st1.Average.CompareTo(st2.Average);
            });
        }

        public void SortByName()
        {
            studentList.Sort(delegate (Student st1, Student st2)
            {
                return st1.Name.CompareTo(st2.Name);
            });
        }

        public void SortBySID()
        {
            studentList.Sort(delegate (Student st1, Student st2)
            {
                return st1.SID.CompareTo(st2.SID);
            });
        }
    }
}