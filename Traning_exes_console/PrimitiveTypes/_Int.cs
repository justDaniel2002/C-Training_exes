using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.PrimitiveTypes
{
    internal class _Int
    {
        public static bool isNumSmallerOrEqualZero(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("Số <= 0");
                return true;
            }
            return false;
        }

        public static bool isEvenNum(int num)
        {
            if ((num % 2) == 0) { Console.WriteLine("Số chẵn"); return true; }
            return false;
        }

        public static bool isOddnNum(int num)
        {
            if ((num % 2) != 0) { Console.WriteLine("Số lẻ"); return true; }
            return false;
        }


        public static bool isElementNum(int num)
        {
            if (num <= 0) return false;

            if( num == 1 || num == 2) return true;

            for(int i = 2; i < num-1; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        public static bool isNumStr(string str)
        {
            int result;
            bool isNum = Int32.TryParse(str, out result);
            return isNum;
        }

        public static void Menu()
        {
            Console.WriteLine("1. input 1 số" +
                "\n2. input 1 số, hiển thị giá trị tuyệt đối của x" +
                "\n3. input 1 số, hiển thị 2 mũ x" +
                "\n4 input 2 số, hiển thị kết quả x chia y" +
                "\n5. input 1 số, nếu là số nguyên tố..." +
                "\n6. input 1 chuỗi, nếu là chuỗi số...");

            Console.Write("option (1-6): ");
        }

        public static void method1(int num)
        {
            if (isNumSmallerOrEqualZero(num)) { }
            else if (isEvenNum(num)) { }
            else if (isOddnNum(num)) { }
        }


        public static void method3(int num)
        {
            if (isNumSmallerOrEqualZero(num)) { }
            else
            {
                Console.WriteLine($"2 ^ {num}: {Math.Pow(2, num)}");
            }
        }

        public static void method4(int num1, int num2)
        {
            Console.WriteLine($"kết quả của {num1} chia {num2} bằng {num1/num2} dư {num1%num2}");
        }

        public static void method5(int num)
        {
            if (isNumSmallerOrEqualZero(num)) { }
            else if (isElementNum(num)) {
                Console.WriteLine("Số nguyên tố");
            }
        }

        public static void method6(string str)
        {
            if (isNumStr(str)) Console.WriteLine("Chuỗi số");
            else Console.WriteLine("Không phải chuỗi số");
        }
        public static void HandleCase(int option)
        {
            switch(option)
            {
                case 1:
                    method1(Helper.inputInt());
                    break;
                case 2:
                    Console.WriteLine($"Giá trị tuyệt đối {Math.Abs(Helper.inputInt())}");
                    break;
                case 3:
                    method3(Helper.inputInt());
                    break;
                case 4:
                    dynamic inputs = Helper.input2int();
                    method4(inputs.input1, inputs.input2);
                    break;
                case 5:
                    method5(Helper.inputInt());
                    break;
                case 6:
                    method6(Helper.inputStr());
                    break;
            }
        }
    }
}
