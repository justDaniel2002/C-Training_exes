using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Traning_exes_console
{
    internal class Helper
    {
        public static string[] vietnameseWeekdays = new string[]
            {
            "Chủ Nhật", // Sunday
            "Thứ Hai",  // Monday
            "Thứ Ba",   // Tuesday
            "Thứ Tư",   // Wednesday
            "Thứ Năm",  // Thursday
            "Thứ Sáu",  // Friday
            "Thứ Bảy"   // Saturday
            };
        public static string inputStr(string content= "Input một chuỗi: ")
        {
            Console.WriteLine(content);
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

        public static int inputInt(string content = "Input một số: ")
        {
            Console.WriteLine(content);
            string str = Console.ReadLine();
            try
            {
                int num = int.Parse(str);
                return num;
            }
            catch (Exception ex)
            {
                return inputInt(content);
            }
        }

        public static DateTime inputDateTime()
        {
            Console.WriteLine("Input date time MM/dd/yyyy: ");
            string str = Console.ReadLine();
            bool isParse = DateTime.TryParse(str, out DateTime dt);
            if (isParse)
            {
                return dt;
            }
            return inputDateTime();

        }

        public static string ConvertToVietnameseDate(DateTime date)
        {
            

            // Get the day of the week in Vietnamese
            string vietnameseDayOfWeek = vietnameseWeekdays[(int)date.DayOfWeek];

            // Format the date as "DayOfWeek, Day Month Year"
            string formattedDate = $"{vietnameseDayOfWeek}, ngày {date.Day} tháng {date.Month} năm {date.Year}";

            return formattedDate;
        }

        public static dynamic input2Datetime()
        {
            Console.WriteLine("input 2 ngày khác nhau");
            DateTime input1 = inputDateTime();
            DateTime input2 = inputDateTime();
            return new { input1, input2};
        }

        public static Dictionary<string, string> inputDictionary(Dictionary<string, string>? dictionary)
        {
            string key = inputStr("Nhập vào key");
            string value = inputStr("Nhập vào value");
            if(dictionary==null) dictionary = new Dictionary<string, string>();
            dictionary.Add(key, value);

            return dictionary;
        }

        public static Dictionary<string, string> inputDictionaries()
        {
            var dictionary = new Dictionary<string, string>();
            do
            {
                inputDictionary(dictionary);
            }
            while (inputYN());

            return dictionary;
        }

        public static bool inputYN(string content = "Bạn có muốn tiếp tục không ?Y/N: ")
        {
            Console.Write(content);
            string input = Console.ReadLine();
            if (input.ToLower() == "n") return false;
            else if (input.ToLower() == "y") return true;
            else return inputYN(content);
        }

        public static bool IsValidNumericString(string input)
        {
            // Regular expression pattern
            string pattern = @"^(\d+ )*\d+$";

            // Check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }
    }
}
