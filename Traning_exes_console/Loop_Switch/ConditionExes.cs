using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Traning_exes_console.Condition
{
    //todo: Chuyển hàm về dạng input, output
    //todo: Kiểm tra lại quy tắc đặt tên hàm, biến
    internal class ConditionExes
    {
        /// <summary>
        /// Nhập 1 giá tri vào console, kiểm tra xem giá trị đó có phải kiểu ngày tháng, kiểu nguyên, kiểu số, kiểu bool
        /// </summary>
        public static void CheckInputDataType(string str)
        {
            if (Isint(str)) Console.WriteLine("Chuỗi nhập vào là số nguyên");
            else if (IsNumeric(str)) Console.WriteLine("Chuỗi nhập vào là một số");
            else if (IsBool(str)) Console.WriteLine("Chuỗi nhập vào là một giá trị boolean");
            else if (IsDateTime(str)) Console.WriteLine("Chuỗi nhập vào là Datetime");
            else Console.WriteLine("Chuỗi nhập vào là một chuỗi string");
        }

        /// <summary>
        /// Nhập 1 giá trị ngày vào console, hiển thị thứ bằng tiếng việt
        /// </summary>
        public static void DisplayDayOfWeek(DateTime dt)
        {
            Console.Write($"Date time nhập vào là ");
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.Write("thứ Hai\n");
                    break;
                case DayOfWeek.Tuesday:
                    Console.Write("thứ Ba\n");
                    break;
                case DayOfWeek.Wednesday:
                    Console.Write("thứ Tư\n");
                    break;
                case DayOfWeek.Thursday:
                    Console.Write("thứ Năm\n");
                    break;
                case DayOfWeek.Friday:
                    Console.Write("thứ Sáu\n");
                    break;
                case DayOfWeek.Saturday:
                    Console.Write("thứ Bảy\n");
                    break;
                case DayOfWeek.Sunday:
                    Console.Write("Chủ Nhật\n");
                    break;
            }
        }


        /// <summary>
        /// Nhập 1 giá trị ngày giờ và 1 giá trị number vào console, mỗi giây in ngày tiếp theo tính từ ngày nhập vào trong number giây
        /// </summary>
        public static void SecondLoop(DateTime dt, int looptime)
        {
            // bài này cần nhập cả số X để in trong X giây thôi mà
            Console.WriteLine(string.Format("Ngày giờ hiện tại: {0}", dt.ToString()));
            while (looptime > 0)
            {
                dt = dt.AddSeconds(1);
                Thread.Sleep(1000);
                Console.WriteLine(string.Format("Ngày giờ hiện tại: {0}", dt.ToString()));
                looptime--;
            }
        }

        /// <summary>
        /// Nhập 1 giá trị number vào console, in ra 10 ngày liên tiếp tính từ ngày number của tháng kế tiếp
        /// </summary>
        public static void TenDaysOfNextMonth(int day)
        {
            var nextMonth = DateTime.Now.AddMonths(1);

            DateTime dt = DateTime.Parse($"{nextMonth.Year}/{nextMonth.Month}/{day}");
            Console.WriteLine(string.Format("10 ngày tiếp theo trong ngày {0} của tháng {1}",day, nextMonth.Month));

            for (int i = 0; i < 10; i++)
            {
                var nextDay = dt.AddDays(i + 1);
                if (nextDay.Month != nextMonth.Month)
                {
                    Console.WriteLine(string.Format("Hết tháng {0}", nextMonth.Month));
                    break;
                }

                Console.WriteLine(nextDay.ToString());
            }
        }

        public static bool Isint(string input)
        {
            return int.TryParse(input, out _);
        }

        //todo: Convert string -> decimal
        public static decimal ConvertToDecimal(string input)
        {
            decimal result;
            decimal.TryParse(input, out result);
            return result;
        }

        /// <summary>
        /// Nhập 1 giá trị number vào console, duyệt tối đa 100 vòng theo giá trị vừa nhập và in ra thứ, ngày, tháng, năm kế tiếp theo biến for (Trừ ngày chủ nhật)
        /// </summary>
        public static void DayLoop(int loopTime)
        {
            var dt = DateTime.Now;
            int hadLoop = 0;
            for (int i = 0; i < loopTime; i++)
            {
                if (hadLoop >= 100) break;
                dt = dt.AddDays(i);
                if (dt.DayOfWeek == DayOfWeek.Sunday) continue;
                Console.WriteLine(string.Format("{0}, ngày {1} tháng {2} năm {3}", Helper.vietnameseWeekdays[dt.DayOfWeek], dt.Day, dt.Month, dt.Year));
                hadLoop++;
                Thread.Sleep(500);
            }
        }


        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
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
                    CheckInputDataType(Helper.InputStr());
                    break;
                case 2:
                    DisplayDayOfWeek(Helper.InputDateTime());
                    break;
                case 3:
                    SecondLoop(Helper.InputDateTime(), Helper.InputInt("Nhập số lần lặp"));
                    break;
                case 4:
                    TenDaysOfNextMonth(Helper.InputDayInNextMonth(DateTime.Now.AddMonths(1)));
                    break;
                case 5:
                    DayLoop(Helper.InputInt("Nhập vào số lần lặp (tối đa 100): "));
                    break;
            }
        }
    }
}
