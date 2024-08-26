using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;

namespace Traning_exes_console.PrimitiveTypes
{
    internal class _String
    {

        public static string spaceRegex = @"\s+";

        public static bool baseMedthod(string str, Func<string, string>? method = null){
            if (str == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return false;
            }
            else if (str.Length == 0)
            {
                Console.WriteLine("Chuỗi rỗng");
                return false;
            }
            else if (str.Trim().Length == 0)
            {
                Console.WriteLine("Chuỗi space");
                return false;
            }
            else if (method != null) 
            {
                method(str);
            }
            return true;
        }
        public static string method1(string str)
        {
            Console.WriteLine(str);
            return str;
        }

        public static string method2(string str)
        {
            
                Console.WriteLine(str.Trim());
            return str;

        }

        public static string method3(string str)
        {
            
                Console.WriteLine(Regex.Replace(str, spaceRegex, ""));
            return str;

        }

        public static string method4(string str)
        {
            
                string[] words = Regex.Split(str, spaceRegex);
                for(int i=0; i<words.Length;i++)
                {
                    words[i] = Regex.Replace(words[i], @"\b\w", match => match.Value.ToUpper());
                }

                string finalStr = "";
                foreach (string word in words)
                {
                    finalStr += word+" ";
                }

                Console.WriteLine(finalStr.Trim());
            return finalStr;

        }

        public static string method5(string str)
        {
            
                string[] words = Regex.Split(str, spaceRegex);
                
                Console.WriteLine($"có {words.Count()-1} ký tự space");

            return str;

        }

        public static string method6(string str)
        {
                string strWithOutSpace = Regex.Replace(str, spaceRegex, "");
                Console.WriteLine($"có {strWithOutSpace.Count()} ký tự không phải space");

            return str;

        }

        public static  void method7(string input1, string input2)
        {
            if (input1.Equals(input2))
            {
                Console.WriteLine($"Chuỗi {input1} giống chuỗi {input2}");
            }
            else
            {
                Console.WriteLine($"Chuỗi {input1} khác chuỗi {input2}");
            }
        }

        public static void method8(string input1, string input2)
        {
            if (input1.ToLower().Equals(input2.ToLower()))
            {
                Console.WriteLine($"Chuỗi {input1} giống chuỗi {input2}");
            }
            else
            {
                Console.WriteLine($"Chuỗi {input1} khác chuỗi {input2}");
            }
        }

        public static string method9(string input1)
        {
            input1 = input1.Replace("ABC", "DEF");
            Console.WriteLine(input1);

            return input1;
        }

        public static string method10(string input)
        {
            Console.WriteLine($"Kính chào ông {input}, Chúc ngon miệng");

            return input;
        }

        public static string method11(string str)
        {
            string reversed = new string(str.Reverse().ToArray());
            Console.WriteLine(reversed);

            return reversed;
        }

        public static void method12(string str, int num)
        {
            bool validStr = baseMedthod(str);

            if(num < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
            }
            else if (num > str.Length)
            {
                Console.WriteLine("Số lớn hơn độ dài str");
            }
            else if (validStr)
            {
                str = str.TrimStart();
                Console.WriteLine(str.Substring(0, num));
            }
        }

        public static void method13(string str, int num)
        {
            bool validStr = baseMedthod(str);

            if (num < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
            } else if (num > str.Length)
            {
                Console.WriteLine("Số lớn hơn độ dài str");
            }
            else if (validStr)
            {
                str = str.Trim();
                Console.WriteLine(str.Substring(0, num));
            }
        }

        public static void method14(string str, int num)
        {
            bool validStr = baseMedthod(str);

            if (num < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
            }
            else if (num > str.Length)
            {
                Console.WriteLine("Số lớn hơn độ dài str");
            }
            else if (validStr)
            {
                str = str.Trim();
                Console.WriteLine(str.Substring(str.Length-num, num));
            }
        }


        public static void Menu()
        {
            Console.WriteLine("1.1 input một chuỗi" +
                   "\n1.2 input một chuỗi, In chuỗi ký tự sau khi bỏ ký tự trắng ở đầu và cuối" +
                   "\n1.3 input một chuỗi, In chuỗi ký tự sau khi bỏ hết ký tự trắng" +
                   "\n1.4 input một chuỗi, In chuỗi ký tự sau khi chuyển thành chữ hoa các ký tự đứng sau dấu Space" +
                   "\n1.5 input một chuỗi, Đếm và thông báo số ký tự Space" +
                   "\n1.6 input một chuỗi, Đếm và thông báo số ký tự không phải Space" +
                   "\n1.7 Input: 2 chuỗi đầu vào" +
                   "\n1.8 Input: 2 chuỗi đầu vào, nhưng không phân biệt hoa thường" +
                   "\n1.9 input một chuỗi, Thay thếcác đoạn \"ABC\" có trong chuỗi đầu vào bằng \"DEF\", CÓ phân biệt hoa thường" +
                   "\n1.10 input một chuỗi, Hiển thị chuỗi: Kính chào ông input. Chúc ngon miệng" +
                   "\n1.11 input một chuỗi, Đảo ngược các ký tự của chuỗi và in ra màn hình chuỗi đầu vào và chuỗi kết quả" +
                   "\n1.12 Input: 1 chuỗi và 1 số" +
                   "\n1.13 Input: 1 chuỗi và 1 số, Còn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự ĐẦU và in kết quả ra màn hình" +
                   "\n1.14 Input: 1 chuỗi và 1 số, Còn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự CUỐI và in kết quả ra màn hình");

            Console.Write("option (1-14): ");
        }


        public static void HandleCase(int option)
        {
            dynamic inputs = null;
            switch (option)
            {
                case 1:
                    //1.1
                    baseMedthod(Helper.inputStr(), method1);
                    break;
                case 2:
                    //1.2
                    baseMedthod(Helper.inputStr(), method2);
                    break;
                case 3:
                    //1.3
                    baseMedthod(Helper.inputStr(), method3);
                    break;
                case 4:
                    //1.4
                    baseMedthod(Helper.inputStr(), method4);
                    break;
                case 5:
                    //1.5
                    baseMedthod(Helper.inputStr(), method5);
                    break;
                case 6:
                    //1.6
                    baseMedthod(Helper.inputStr(), method6);
                    break;
                case 7:
                    inputs = Helper.input2Str();
                    //1.1.7
                    method7(inputs.input1, inputs.input2);
                    break;
                case 8:
                    inputs = Helper.input2Str();
                    //1.1.8
                    method8(inputs.input1, inputs.input2);
                    break;
                case 9:
                    //1.1.9
                    baseMedthod(Helper.inputStr(), method9);
                    break;
                case 10:
                    //1.1.10
                    baseMedthod(Helper.inputStr(), method10);
                    break;
                case 11:
                    //1.1.11
                    baseMedthod(Helper.inputStr(), method11);
                    break;
                case 12:
                    //1.1.12
                    method12(Helper.inputStr(), Helper.inputInt());
                    break;
                case 13:
                    //1.1.13
                    method13(Helper.inputStr(), Helper.inputInt());
                    break;
                case 14:
                    //1.1.14
                    method14(Helper.inputStr(), Helper.inputInt());
                    break;

            }
        }
    }
}
