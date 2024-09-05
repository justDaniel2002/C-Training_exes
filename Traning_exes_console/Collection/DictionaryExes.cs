using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.Collection
{
    //todo: Chuyển hàm về dạng input, output
    //todo: Kiểm tra lại quy tắc đặt tên hàm, biến
    internal class DictionaryExes
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

        public static bool IsStudentCodeExist(string studentCode, Dictionary<string, string> studentsDictionary)
        {
            return studentsDictionary.ContainsKey(studentCode);
        }

        public static void PrintDictionary(Dictionary<string, string> dictionary)
        {
           foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key} - Value: {kvp.Value}");
            }
        }

        /// <summary>
        /// Nhập 1 Dictionary, 1 mã SV và tên SV
        /// Nếu mã SV đó có trong Dictionary, in tên SV đó
        ///Ngược lại thông báo: Không có SV có mã...

        /// </summary>
        public static void Method2(Dictionary<string, string> dictionary, string studentCode)
        {
            if(IsStudentCodeExist(studentCode, dictionary))
            {
                Console.WriteLine($"Tên sinh viên: {dictionary[studentCode]}");
            }
            else
            {
                Console.WriteLine($"Không có sinh viên có mã {studentCode}");
            }
        }

        /// <summary>
        /// Nhập 1 Dictionary, 1 mã SV và tên SV
        ///Nếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm SV có mã..., tên...vào Dictionary
        ///Ngược lại thông báo: Đã có SV có mã...trong Dictonary


        /// </summary>
        public static void Method3(Dictionary<string, string> dictionary, string studentCode, string studentName)
        {
            if (IsStudentCodeExist(studentCode, dictionary))
            {
                Console.WriteLine("Đã có mã sinh viên trong dictionary");
            }else
            {
                dictionary.Add(studentCode, studentName);
                Console.WriteLine($"Đã thêm sinh viên có mã {studentName} vào dictionary");
                PrintDictionary(dictionary);
            }
        }

        /// <summary>
        /// Nhập 1 Dictionary, 1 mã SV và tên SV
        ///Nếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm SV có mã..., tên...vào Dictionary
        ///Ngược lại thay tên SV cũ bằng tên SV mới, thông báo: Đãthaytên SV có mã...trong Dictonary từ... thành...


        /// </summary>
        public static void Method4(Dictionary<string, string> dictionary, string studentCode, string studentName)
        {
            if (IsStudentCodeExist(studentCode, dictionary))
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
            PrintDictionary(dictionary);
        }

        /// <summary>
        /// Nhập 1 Dictionary, 1 mã SV
        ///Nếu mã SV đó có trong Dictionary, bỏ mã SV đó khỏi Dictionary
        ///Ngược lại thông báo: Không có SV có mã...


        /// </summary>
        public static void Method5(Dictionary<string, string> dictionary, string studentCode)
        {
            if (IsStudentCodeExist(studentCode, dictionary))
            {
                dictionary.Remove(studentCode);
                PrintDictionary(dictionary);
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
                    PrintDictionary(Helper.InputDictionaries());
                    break;
                case 2:
                    Method2(Helper.InputDictionaries(), Helper.InputStr("input mã sinh viên"));
                    break;
                case 3:
                    Method3(Helper.InputDictionaries(), Helper.InputStr("input mã sinh viên"), Helper.InputStr("input tên sinh viên"));
                    break;
                case 4:
                    Method4(Helper.InputDictionaries(), Helper.InputStr("input mã sinh viên"), Helper.InputStr("input tên sinh viên"));
                    break;
                case 5:
                    Method5(Helper.InputDictionaries(), Helper.InputStr("input mã sinh viên"));
                    break;
            }
        }
    }
}
