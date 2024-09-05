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
        public static Dictionary<DayOfWeek, string> vietnameseWeekdays = new Dictionary<DayOfWeek, string>
        {
            {DayOfWeek.Monday, "Thứ Hai" },
            {DayOfWeek.Tuesday, "Thứ Ba" },
            {DayOfWeek.Wednesday, "Thứ Tư" },
            {DayOfWeek.Thursday, "Thứ Năm" },
            {DayOfWeek.Friday, "Thứ Sáu" },
            {DayOfWeek.Saturday, "Thứ Bảy" },
            {DayOfWeek.Sunday, "Chủ Nhật" },
        };
        public static string InputStr(string content= "Input một chuỗi: ")
        {
            Console.WriteLine(content);
            string str = Console.ReadLine();
            return str;
        }

        public static dynamic Input2Str()
        {
            Console.WriteLine("Input hai chuỗi: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            return new { input1, input2 };
        }

        public static dynamic Input2int()
        {
            Console.WriteLine("Input hai số: ");
            int input1 = InputInt();
            int input2 = InputInt();
            return new { input1, input2 };
        }

        public static int InputInt(string content = "Input một số: ")
        {
            int num;
            Console.WriteLine(content);
            string str = Console.ReadLine();
            try
            {
                num = int.Parse(str);
                
            }
            catch (Exception FormatException)
            {
                //return InputInt(content);
                Console.WriteLine("Inout nhập vào không phải là một số");
                throw FormatException;
            }
            return num;
        }

        public static DateTime InputDateTime()
        {
            Console.WriteLine("Input date time MM/dd/yyyy: ");
            string str = Console.ReadLine();
            bool isParse = DateTime.TryParse(str, out DateTime dt);
            if (isParse)
            {
                return dt;
            }
            //return InputDateTime();
            throw new FormatException("Input không đúng định dạng ngày tháng năm");

        }

        public static string ConvertToVietnameseDate(DateTime date)
        {
            

            // Get the day of the week in Vietnamese
            string vietnameseDayOfWeek = vietnameseWeekdays[date.DayOfWeek];

            // Format the date as "DayOfWeek, Day Month Year"
            string formattedDate = $"{vietnameseDayOfWeek}, ngày {date.Day} tháng {date.Month} năm {date.Year}";

            return formattedDate;
        }

        public static dynamic Input2Datetime()
        {
            Console.WriteLine("input 2 ngày khác nhau");
            DateTime input1 = InputDateTime();
            DateTime input2 = InputDateTime();
            return new { input1, input2};
        }

        public static Dictionary<string, string> InputDictionary(Dictionary<string, string>? dictionary)
        {
            string key = InputStr("Nhập vào key");
            string value = InputStr("Nhập vào value");
            if(dictionary==null)
            {
                //dictionary = new Dictionary<string, string>();
                throw new ArgumentNullException("input dictionary là null");
            }
            dictionary.Add(key, value);

            return dictionary;
        }

        public static Dictionary<string, string> InputDictionaries()
        {
            var dictionary = new Dictionary<string, string>();
            do
            {
                InputDictionary(dictionary);
            }
            while (InputYN());

            return dictionary;
        }

        public static bool InputYN(string content = "Bạn có muốn tiếp tục không ?Y/N: ")
        {
            Console.Write(content);
            string input = Console.ReadLine();
            if (input.ToLower() == "n") return false;
            else if (input.ToLower() == "y") return true;
            else
            {
                // return InputYN(content)
                throw new FormatException("Nhập vào sai định dạng");
            };
        }

        public static bool IsValidNumericString(string input)
        {
            // Regular expression pattern
            string pattern = @"^(\d+ )*\d+$";

            // Check if the input matches the pattern
            return Regex.IsMatch(input, pattern);
        }

        static bool IsDayInMonth(DateTime date, int day)
        {
            // Get the number of days in the month
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            // Check if the input day is within the valid range
            return day >= 1 && day <= daysInMonth;
        }

        public static int InputDayInNextMonth(DateTime nextMonth)
        {
            int day = InputInt("Nhập vào 1 ngày trong tháng tiếp");
            if (!IsDayInMonth(nextMonth, day))
            {
                Console.WriteLine($"Tháng tiếp không có ngày {day}");
                //return InputDayInNextMonth(nextMonth);
                throw new Exception($"Tháng tiếp không có ngày {day}");
            }
            return day;
        }
    }
}
