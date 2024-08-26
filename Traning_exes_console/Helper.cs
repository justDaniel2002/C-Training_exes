using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console
{
    internal class Helper
    {
        public static string inputStr()
        {
            Console.WriteLine("Input một chuỗi: ");
            string str = Console.ReadLine();
            return str;
        }

        public static dynamic input2Str()
        {
            Console.WriteLine("Input hai chuỗi: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            return new { input1, input2 };
        }

        public static dynamic input2int()
        {
            Console.WriteLine("Input hai số: ");
            int input1 = inputInt();
            int input2 = inputInt();
            return new { input1, input2 };
        }

        public static int inputInt()
        {
            Console.WriteLine("Input một số: ");
            string str = Console.ReadLine();
            try
            {
                int num = int.Parse(str);
                return num;
            }
            catch (Exception ex)
            {
                return inputInt();
            }
        }
    }
}
