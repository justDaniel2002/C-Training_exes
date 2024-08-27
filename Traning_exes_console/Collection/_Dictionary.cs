using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.Collection
{
    internal class _Dictionary
    {
       
        public static void Menu()
        {
            Console.WriteLine("1. tạo 1 dictionary, thêm vào 5 giá trị" +
                "\n2. Nhập 1 Dictionary, 1 mã SV, Nếu mã SV đó có trong Dictionary..." +
                "\n3. Nhập 1 Dictionary, 1 mã SV và tên SV, Nếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary." +
                "\n4. Nhập 1 Dictionary, 1 mã SV và tên SV\r\nNếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary" +
                "Ngược lại thay tên SV cũ bằng tên SV mới, thông báo" +
                "\n5. Nhập 1 Dictionary, 1 mã SV\r\nNếu mã SV đó có trong Dictionary, bỏ mã SV đó khỏi Dictionary\r\n");
        }

        public static bool isStudentCodeExist(string studentCode, Dictionary<string, string> studentsDictionary)
        {
            var student = studentsDictionary.GetValueOrDefault(studentCode);

            if (student == null) return false;

            return true;
        }

        public static void printDictionary(Dictionary<string, string> dictionary)
        {
           foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key} - Value: {kvp.Value}");
            }
        }

        public static void method2(Dictionary<string, string> dictionary, string studentCode)
        {
            if(isStudentCodeExist(studentCode, dictionary))
            {
                Console.WriteLine($"Tên sinh viên: {dictionary[studentCode]}");
            }
            else
            {
                Console.WriteLine($"Không có sinh viên có mã {studentCode}");
            }
        }

        public static void method3(Dictionary<string, string> dictionary, string studentCode, string studentName)
        {
            if (isStudentCodeExist(studentCode, dictionary))
            {
                Console.WriteLine("Đã có mã sinh viên trong dictionary");
            }else
            {
                dictionary.Add(studentCode, studentName);
                Console.WriteLine($"Đã thêm sinh viên có mã {studentName} vào dictionary");
                printDictionary(dictionary);
            }
        }

        public static void method4(Dictionary<string, string> dictionary, string studentCode, string studentName)
        {
            if (isStudentCodeExist(studentCode, dictionary))
            {
                string oldname = dictionary[studentCode];
                dictionary[studentCode] = studentName;
                Console.WriteLine($"Đã thay tên thay tên sinh viên có mã {studentCode} từ {oldname} thành {studentName}");
            }
            else
            {
                dictionary.Add(studentName, studentCode);
                Console.WriteLine($"Đã thêm sinh viên có mã {studentName} vào dictionary");
                
            }
            printDictionary(dictionary);
        }

        public static void method5(Dictionary<string, string> dictionary, string studentCode)
        {
            if (isStudentCodeExist(studentCode, dictionary))
            {
                dictionary.Remove(studentCode);
                printDictionary(dictionary);
            }
            else
            {
                Console.WriteLine($"Không có sinh viên có mã {studentCode}");
            }
        }
        public static void HandleCase(int option)
        {
            switch(option)
            {
                case 1:
                    printDictionary(Helper.inputDictionaries());
                    break;
                case 2:
                    method2(Helper.inputDictionaries(), Helper.inputStr("input mã sinh viên"));
                    break;
                case 3:
                    method3(Helper.inputDictionaries(), Helper.inputStr("input mã sinh viên"), Helper.inputStr("input tên sinh viên"));
                    break;
                case 4:
                    method4(Helper.inputDictionaries(), Helper.inputStr("input mã sinh viên"), Helper.inputStr("input tên sinh viên"));
                    break;
                case 5:
                    method5(Helper.inputDictionaries(), Helper.inputStr("input mã sinh viên"));
                    break;
            }
        }
    }
}
