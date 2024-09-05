using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.PrimitiveTypes
{
    //todo: Chuyển hàm về dạng input, output
    //todo: Kiểm tra lại quy tắc đặt tên hàm, biến
    internal class IntExes
    {
        public static bool IsNumSmallerOrEqualZero(int num)
        {
            if (num <= 0)
                
                return true;
            
            return false;
        }

        public static bool IsEvenNum(int num)
        {
            if ((num % 2) == 0)  return true; 
            return false;
        }

        public static bool IsOddnNum(int num)
        {
            if ((num % 2) != 0)  return true; 
            return false;
        }


        public static bool IsElementNum(int num)
        {
            if (num <= 0) return false;

            if( num == 1 || num == 2) return true;

            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }

        public static bool IsNumStr(string str)
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

        /// <summary>
        /// Input: 1 số
        ///Nếu số <= 0 -> Thông báo: Số <= 0
        ///Còn lại: Nếu là số chẵn -> Thông báo: Số chẵn
        ///Nếu là số lẻ -> Thông báo: Số lẻ

        /// </summary>
        public static void Method1(int num)
        {
            if (IsNumSmallerOrEqualZero(num)) { Console.WriteLine("Số <= 0");  }
            else if (IsEvenNum(num)) { Console.WriteLine("Số chẵn");  }
            else if (IsOddnNum(num)) { Console.WriteLine("Số lẻ");  }
        }

        /// <summary>
        /// Input: 1 số
        ///Nếu số <= 0 -> Thông báo: Số <= 0
        ///Còn lại: Hiển thị 2 mũ x

        /// </summary>
        public static void Method3(int num)
        {
            // Viết tn cho đơn giản
            if (!IsNumSmallerOrEqualZero(num))
            {
                Console.WriteLine($"2 ^ {num}: {Math.Pow(2, num)}");
            }
        }

        /// <summary>
        /// Input: 2 số (X, Y) 
        ///Hiển thị kết quả: X chia Y bằng...dư...

        /// </summary>
        public static void Method4(int num1, int num2)
        {
            Console.WriteLine($"kết quả của {num1} chia {num2} bằng {num1/num2} dư {num1%num2}");
        }


        /// <summary>
        /// Input: 1 số
        ///Nếu số <= 0 -> Thông báo: Số <= 0
        ///Còn lại: Nếu là số nguyên tố -> Thông báo: Số nguyên tố

        /// </summary>
        public static void Method5(int num)
        {
            if (IsNumSmallerOrEqualZero(num)) { }
            else if (IsElementNum(num)) {
                Console.WriteLine("Số nguyên tố");
            }
        }

        /// <summary>
        /// Input: 1 chuỗi.
        ///Nếu chuỗi là chuỗi số Int32 -> Thông báo: Chuỗi số.
        ///Ngược lai -> Thông báo: Không phải chuỗi số

        /// </summary>
        public static void Method6(string str)
        {
            if (IsNumStr(str)) Console.WriteLine("Chuỗi số");
            else Console.WriteLine("Không phải chuỗi số");
        }
        public static void HandleCase(int option)
        {
            switch(option)
            {
                case 1:
                    Method1(Helper.InputInt());
                    break;
                case 2:
                    Console.WriteLine($"Giá trị tuyệt đối {Math.Abs(Helper.InputInt())}");
                    break;
                case 3:
                    Method3(Helper.InputInt());
                    break;
                case 4:
                    dynamic inputs = Helper.Input2int();
                    Method4(inputs.input1, inputs.input2);
                    break;
                case 5:
                    Method5(Helper.InputInt());
                    break;
                case 6:
                    Method6(Helper.InputStr());
                    break;
            }
        }
    }
}
