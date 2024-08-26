using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
    }
}
