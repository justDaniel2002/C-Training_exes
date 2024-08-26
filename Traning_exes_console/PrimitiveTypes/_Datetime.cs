using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.PrimitiveTypes
{
    internal class _Datetime
    {
        CultureInfo vietnameseCulture = new CultureInfo("vi-VN");
        public static void Menu()
        {
            Console.WriteLine("1.Lấy ngày hôm nay" +
                "\n2.Input 1 ngày, Thông báo: Hôm nay là thứ ..., tháng..., năm..." +
                "\n3.Input 1 ngày, Thông báo: Hôm sau là thứ ..., tháng..., năm..." +
                "\n4.Input 1 ngày, Thông báo: Hôm trước là thứ ..., tháng..., năm..." +
                "\n5.Input 1 ngày, Nếu là hôm nay ..." +
                "\n6.Input 1 ngày, Hiển thị ngày dưới dạng..." +
                "\n7.Input 1 ngày, Hiển thị 10 ngày trước là thứ mấy." +
                "\n8.Input 1 ngày, Hiển thị cuối tháng này là thứ mấy." +
                "\n10.Input 1 ngày, Hiển thị cuối năm nay là thứ mấy.");
        }

        public static void method5(DateTime dateinput)
        {
            if(dateinput.Date == DateTime.Today)
            {
                Console.WriteLine("Ngày hôm nay");
            }else if (dateinput.Date < DateTime.Today)
            {
                Console.WriteLine("Ngày quá khứ");
            }
            else if (dateinput.Date > DateTime.Today)
            {
                Console.WriteLine("Ngày tương lai");
            }
        }

        public static void method6(DateTime dateinput)
        {
            Console.WriteLine(dateinput.ToString("dd/MM/yyyy"));
            Console.WriteLine(dateinput.ToString("yyyy/MM/dd"));
            Console.WriteLine(dateinput.ToString("MM/yyyy"));
            Console.WriteLine(dateinput.ToString("MM-yyyy"));
        }

        public static void method7(DateTime dateinput)
        {
            DateTime tenDayslater = dateinput.AddDays(10);
            Console.WriteLine($"10 ngày trước là thứ {Helper.vietnameseWeekdays[(int)tenDayslater.DayOfWeek]}");
        }

        public static void method8(DateTime dateinput)
        {
            DateTime endOfMonth = new DateTime(dateinput.Year, dateinput.Month, DateTime.DaysInMonth(dateinput.Year, dateinput.Month));
            Console.WriteLine($"ngày cuối cùng của tháng là thứ {Helper.vietnameseWeekdays[(int)endOfMonth.DayOfWeek]}");

        }

        public static void method10(DateTime dateinput)
        {
            DateTime endOfYear = new DateTime(dateinput.Year, 12, DateTime.DaysInMonth(dateinput.Year, 12));
            Console.WriteLine($"ngày cuối cùng của năm là thứ {Helper.vietnameseWeekdays[(int)endOfYear.DayOfWeek]}");

        }

        public static void method11(DateTime dateinput, DateTime dateinput2)
        {
            Console.WriteLine($"2 ngày này cách nhau {Math.Abs((dateinput - dateinput2).Days)}");
        }
        public static void HandleCase(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(DateTime.Now));
                    break;
                case 2:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(Helper.inputDateTime()));
                    break;
                case 3:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(Helper.inputDateTime().AddDays(1)));
                    break;
                case 4:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(Helper.inputDateTime().AddDays(-1)));
                    break;
                case 5:
                    method5(Helper.inputDateTime());
                    break;
                case 6:
                    method6(Helper.inputDateTime());
                    break;
                case 7:
                    method7(Helper.inputDateTime());
                    break;
                case 8:
                    method8(Helper.inputDateTime());
                    break;
                case 10:
                    method10(Helper.inputDateTime());
                    break;
                case 11:
                    dynamic inputs = Helper.input2Datetime();
                    method11(inputs.input1, inputs.input2);
                    break;

            }
        }
    }
}
