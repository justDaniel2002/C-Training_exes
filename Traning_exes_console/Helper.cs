using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static DateTime inputDateTime()
        {
            Console.WriteLine("Input date time dd/MM/yyyy: ");
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
    }
}
