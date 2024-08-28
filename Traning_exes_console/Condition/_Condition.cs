using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Traning_exes_console.Condition
{
    internal class _Condition
    {
        public static void checkInputDataType(string str)
        {
            if (Isint(str)) Console.WriteLine("Chuỗi nhập vào là số nguyên");
            else if (IsNumeric(str)) Console.WriteLine("Chuỗi nhập vào là một số");
            else if (IsBool(str)) Console.WriteLine("Chuỗi nhập vào là một giá trị boolean");
            else if (IsDateTime(str)) Console.WriteLine("Chuỗi nhập vào là Datetime");
            else Console.WriteLine("Chuỗi nhập vào là một chuỗi string");
        }

        public static void displayDayOfWeek(DateTime dt)
        {
            int dayOfW = (int)dt.DayOfWeek;
            Console.Write($"Date time nhập vào là ");
            switch (dayOfW)
            {
                case 1:
                    Console.Write("thứ Hai\n");
                    break;
                case 2:
                    Console.Write("thứ Ba\n");
                    break;
                case 3:
                    Console.Write("thứ Tư\n");
                    break;
                case 4:
                    Console.Write("thứ Năm\n");
                    break;
                case 5:
                    Console.Write("thứ Sáu\n");
                    break;
                case 6:
                    Console.Write("thứ Bảy\n");
                    break;
                case 0:
                    Console.Write("Chủ Nhật\n");
                    break;
            }
        }

        public static void secondLoop(DateTime dt)
        {
            Console.WriteLine($"Ngày giờ hiện tại: {dt.ToString()}");
            while(true)
            {
                dt=dt.AddSeconds(1);
                Thread.Sleep(1000);
                Console.WriteLine($"Ngày giờ hiện tại: {dt.ToString()}");
            }
        }

        public static void tenDaysOfNextMonth(int day)
        {
            var nextMonth = DateTime.Now.AddMonths(1);
            DateTime dt = DateTime.Parse($"{nextMonth.Month}/{day}/{nextMonth.Year}");
            Console.WriteLine($"10 ngày tiếp theo trong ngày {day} của tháng {nextMonth.Month}");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(dt.AddDays(i+1).ToString());
            }
        }

        public static bool Isint(string input) {
            return int.TryParse(input, out _);           
        }

        public static void dayLoop(int loopTime)
        {
            var now = DateTime.Now;
            int hadLoop = 0;
            for(int i = 0; i < loopTime;i++)
            {
                if (hadLoop >= 100) break;
                var dt = now.AddDays(i);
                if ((int)dt.DayOfWeek == 0) continue;
                Console.WriteLine($"{Helper.vietnameseWeekdays[(int)dt.DayOfWeek]}, ngày {dt.Day} tháng {dt.Month} năm {dt.Year}");
                hadLoop++;
                Thread.Sleep(500);
            }
        }

        public static bool IsNumeric(string input)
        {
            return Regex.IsMatch(input, @"^\d+(\.\d+)?$");
        }

        public static bool IsBool(string input)
        {
            return bool.TryParse(input, out _);
        }

        public static bool IsDateTime(string input)
        {
            return DateTime.TryParse(input, out _);
        }

        public static void Menu()
        {
            Console.WriteLine("1. Nhập 1 giá tri vào console, kiểm tra xem giá trị đó có phải kiểu ngày tháng, kiểu nguyên, kiểu số, kiểu bool\n" +
                "2.Nhập 1 giá trị ngày vào consolte, hiển thị thứ bằng tiếng việt\n" +
                "3.Nhập 1 giá trị ngày giờ vào console, mỗi giây in ra một dòng ngày, giờ nhập\n" +
                "4.Nhập 1 giá trị number vào console, In ra 10 ngày kế tiếp tính từ number của tháng kế tiếp\n" +
                "5.Nhập 1 giá trị number vào console, duyệt tối đa 100 vòng theo giá trị vừa nhập và in ra thứ, ngày, tháng, năm kế tiếp theo biến for (Trừ ngày chủ nhật)");
        }

        public static void HandleCase(int option)
        {
            switch (option)
            {
                case 1:
                    checkInputDataType(Helper.inputStr());
                    break;
                case 2:
                    displayDayOfWeek(Helper.inputDateTime());
                    break;
                case 3:
                    secondLoop(Helper.inputDateTime());
                    break;
                case 4:
                    tenDaysOfNextMonth(Helper.InputDayInNextMonth(DateTime.Now.AddMonths(1)));
                    break;
                case 5:
                    dayLoop(Helper.inputInt("Nhập vào số lần lặp (tối đa 100): "));
                    break;
            }
        }
    }
}
