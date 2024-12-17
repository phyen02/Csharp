#pragma warning disable CS8602
#pragma warning disable CS8600
#pragma warning disable CS8604

namespace StudentManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            DisplayMenu();
        }

        public static void DisplayMenu()
        {
            int key = -1;

            StudentManage st = new StudentManage();

            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Modify student by ID");
                Console.WriteLine("3. Delete student by ID");
                Console.WriteLine("4. Search by name");
                Console.WriteLine("5. Sort students by GPA");
                Console.WriteLine("6. Sort students by name");
                Console.WriteLine("7. Sort students by ID");
                Console.WriteLine("8. Show student list");
                Console.WriteLine("0. Exit");
                Console.WriteLine("-------------------------------");
                Console.Write("Option: ");
                key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------");

                switch (key)
                {
                    case 0:
                        break;
                    case 1:
                        st.AddStudent();
                        Console.Write("\nSuccess add student...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("-----Modify student by ID-----");

                        if (st.CountStudent() > 0)
                        {
                            Console.Write("Student's id: ");
                            int sid = Convert.ToInt32(Console.ReadLine());
                            st.ModifyStudentByID(sid);
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("-----Delete student by ID-----");

                        if (st.CountStudent() > 0)
                        {
                            Console.Write("Student's id: ");
                            int sid = Convert.ToInt32(Console.ReadLine());
                            if (st.DeleteStudentByID(sid))
                            {
                                Console.Write("Delete successful");
                            }
                            else
                            {
                                Console.Write("Student doesn't exist");
                            }
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("-----Search student by name-----");
                        if (st.CountStudent() > 0)
                        {
                            Console.Write("Student's name: ");
                            string name = Console.ReadLine();
                            List<Student> students = st.FindByName(name);
                            st.PrintStudentInfo(students);
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("-----Sort by GPA-----");
                        if (st.CountStudent() > 0)
                        {
                            st.SortByGPA();
                            st.PrintStudentInfo(st.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("-----Sort by name-----");
                        if (st.CountStudent() > 0)
                        {
                            st.SortByName();
                            st.PrintStudentInfo(st.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("-----Sort by SID-----");
                        if (st.CountStudent() > 0)
                        {
                            st.SortBySID();
                            st.PrintStudentInfo(st.getListStudent());
                        }
                        else
                        {
                            Console.WriteLine("List is empty");
                        }
                        Console.Write("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    case 8:
                        if (st != null && st.CountStudent() > 0)
                        {
                            st.PrintStudentInfo(st.getListStudent());
                            Console.Write("Enter to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("List is empty");
                            Console.ReadLine();
                        }
                        break;
                    default:
                        break;
                }
            } while (key != 0);
        }

        public static void Test()
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 15}",
                  "ID", "Name", "Gender", "Age", "Math", "Physics", "Chemistry", "Average", "Performance");
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 12} {8, 15}",
                  "1", "A", "Male", "22", "7.8", "7", "9", "8", "Good");
        }
    }
}