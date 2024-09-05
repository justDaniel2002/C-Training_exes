using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Traning_exes_console.LinQ
{
    internal class _LinQ
    {
        public static List<Employee> employees = new List<Employee>
        {
            new Employee{name="TestEmp", year=2000},
            new Employee{name="TestEmp2", year=1999},
            new Employee{name="TestEmp3", year=1998},
            new Employee{name="TestEmp4", year=1997},
            new Employee{name="TestEmp5", year=1996},
            new Employee{name="TestEmp6", year=1995},
            new Employee{name="TestEmp7", year=1994},
        };


        public static  List<Employee> employees2 = new List<Employee>
        {
            new Employee{name="TestEmp6", year=1995},
            new Employee{name="TestEmp7", year=1994},
            new Employee{name="TestEmp8", year=1993},
            new Employee{name="TestEmp9", year=1992},
            new Employee{name="TestEmp10", year=1991},
            new Employee{name="TestEmp11", year=1990},
            new Employee{name="TestEmp12", year=1989},
        };

        /// <summary>
        /// 1.	Tìm tất cả đầu tiên có Tên chứa chuỗi "Test"
        /// </summary>
        public static List<Employee> findEmpByName(string name)
        {
            var searchEmp = (from emp in employees where emp.name.Contains(name) select emp).ToList();
            return searchEmp;
        }

        /// <summary>
        /// 2.	Tìm item đầu tiên có Tên chứa chuỗi "Test"
        /// </summary>
        public static Employee findFirstEmpByName(string name)
        {
            var firstEmp = (from emp in employees where emp.name.Contains(name) select emp).FirstOrDefault();
            return firstEmp;
        }

        /// <summary>
        /// 3.	Lấy danh sách (string) tất cả tên
        /// </summary>
        public static List<string> getEmpName()
        {
            return (from emp in employees select emp.name).ToList();
        }

        /// <summary>
        /// 4.	Lấy danh sách (string) tất cả thông tin theo format: "Ông {0} sinh năm {1}"
        /// </summary>
        public static List<string> getEmpNameByFormat()
        {
            return (from emp in employees select $"Ông {emp.name} sinh năm {emp.year}").ToList();
        }

        /// <summary>
        /// 1.	Tìm tất cả item có tên trong tập 1 mà ko có trong tập 2
        /// </summary>
        public static List<Employee> getEmpOnlyInList1()
        {
            return (from emp in employees where !employees2.Contains(emp) select emp).ToList();
        }

        /// <summary>
        /// 2.	Tìm tất cả item có trong cả 2 tập
        /// </summary>
        public static List<Employee> getEmpOnlyIn2List()
        {
            return (from emp in employees where employees2.Contains(emp) select emp).ToList();
        }

        public static void printEmployees(List<Employee> emps)
        {
            foreach(var emp in emps)
            {
                Console.WriteLine($"nhân viên tên {emp.name} sinh năm {emp.year}");
            }
        }

        public static void printEmployee(Employee emp)
        {
            
                Console.WriteLine($"nhân viên tên {emp.name} sinh năm {emp.year}");
            
        }

        public static void printListString(List<string> list)
        {
            foreach(string str in list){
                Console.WriteLine(str);
            }
        }

        public static void Menu()
        {
            Console.WriteLine("1. Tìm tất cả nhân viên có chứa chuỗi Test" +
                "\n2. Tìm nhân viên đầu tiên có chứa chuỗi Test" +
                "\n3. lấy danh sách string tất cả tên" +
                "\n4. lấy danh sách string tất cả tên theo format" +
                "\n5. tìm tất cả employee có trong tệp 1 mà không có trong tệp 2" +
                "\n6. Tìm employee có ở cả hai tệp");
        }

        public static void HandleCase(int option)
        {
            switch(option)
            {
                case 1:
                    printEmployees(findEmpByName("Test"));
                    break;
                case 2:
                    printEmployee(findFirstEmpByName("Test"));
                    break;
                case 3:
                    printListString(getEmpName());
                    break;
                case 4:
                    printListString(getEmpNameByFormat());
                    break;
                case 5:
                    printEmployees(getEmpOnlyInList1());
                    break;
                case 7:
                    printEmployees(getEmpOnlyIn2List());
                    break;

            }
        }
            

        
    }
}
