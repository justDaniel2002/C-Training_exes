using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.Object
{
    internal class PersonManager
    {
        private static List<Person> persons = new List<Person>();

        private static List<Teacher> teachers = new List<Teacher>();

        private static List<Student> students = new List<Student>();


        public static void InputPerson()
        {
            do
            {
                if (persons.Count == 0)
                {
                    persons.Add(new Person(Helper.inputStr("Nhập tên của Người đầu tiên: "), Helper.inputInt("Nhập tuổi của người đầu tiên: ")));
                }
                else
                {
                    var firstPerson = persons[0];
                    persons.Add(new Person(Helper.inputStr("Nhập tên của Người tiếp theo: "),
                        Helper.inputInt("Nhập tuổi của người tiếp theo: "), persons.Count + 1, firstPerson.CreatedTime));
                }
            } while (Helper.inputYN());
        }

        public static void InputStudent()
        {
            do
            {
                if (students.Count == 0)
                {
                    students.Add(new Student(Helper.inputStr("Nhập tên của học sinh đầu tiên: "), Helper.inputInt("Nhập tuổi của học sinh đầu tiên: ")));
                }
                else
                {
                    var firststudents = students[0];
                    students.Add(new Student(Helper.inputStr("Nhập tên của học sinh tiếp theo: "),
                        Helper.inputInt("Nhập tuổi của học sinh tiếp theo: "), students.Count + 1, firststudents.CreatedTime));
                }
            } while (Helper.inputYN());
        }

        public static void InputTeacher()
        {
            do
            {
                if (teachers.Count == 0)
                {
                    teachers.Add(new Teacher(Helper.inputStr("Nhập tên của giáo viên đầu tiên: "), Helper.inputInt("Nhập tuổi của giáo viên đầu tiên: ")));
                }
                else
                {
                    var firstteachers = teachers[0];
                    teachers.Add(new Teacher(Helper.inputStr("Nhập tên của giáo viên tiếp theo: "),
                        Helper.inputInt("Nhập tuổi của giáo viên tiếp theo: "), teachers.Count + 1, firstteachers.CreatedTime));
                }
            } while (Helper.inputYN());
        }

        public static void printPerson()
        {
            foreach (Person p in persons)
            {
                if (p.Order == 1) p.ShowInfo();
                else p.ExtInfo();
            }
        }

        public static void printStudent()
        {
            foreach (Person p in students)
            {
                if (p.Order == 1) p.ShowInfo();
                else p.ExtInfo();
            }
        }

        public static void printTeacher()
        {
            foreach (Person p in teachers)
            {
                if (p.Order == 1) p.ShowInfo();
                else p.ExtInfo();
            }
        }

        public static void Menu()
        {
            Console.WriteLine("1. Nhập thông tin người" +
                "\n2. Nhập thông tin học sinh" +
                "\n3. Nhập thông tin giáo viên" +
                "\n4. In thông tin người" +
                "\n5. In thông in học sinh" +
                "\n6. In thông tin giáo viên");
        }

        public static void HandleCase(int option)
        {
            switch (option)
            {
                case 1:
                    InputPerson();
                    break;
                case 2:
                    InputStudent();
                    break;
                case 3:
                    InputTeacher();
                    break;
                case 4:
                    printPerson();
                    break;
                case 5:
                    printStudent();
                    break;
                case 6:
                    printTeacher();
                    break;
            }
        }
    }
}
