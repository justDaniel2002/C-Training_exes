using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Traning_exes_console.PrimitiveTypes
{
    //todo: Chuyển hàm về dạng input, output
    //todo: Kiểm tra lại quy tắc đặt tên hàm, biến
    internal class DatetimeExes
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

        /// <summary>
        /// Input: 1 ngày.
        ///Nếu là hôm nay -> Thông báo: Ngày hôm nay
        ///Nếu là sau hôm nay -> Thông báo: Ngày tương lai
        ///Nếu là trước hôm nay -> Thông báo: Ngày quá khứ
        /// </summary>
        public static void Method5(DateTime dateinput)
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

        /// <summary>
        /// Nhập 1 ngày.
        /// Hiển thị ngày dưới dạng: Ngày/tháng/năm.VD:18/03/2014
        /// Hiển thị ngày dưới dạng: Năm/tháng/ngày.VD: 2014/03/18
        /// Hiển thị ngày dưới dạng: Tháng/năm.VD: 03/2014
        /// Hiển thị ngày dưới dạng: Tháng-năm.VD: 03-2014
        /// </summary>
        /// <param name="dateinput"></param>
        public static void Method6(DateTime dateinput)
        {
            Console.WriteLine(dateinput.ToString("dd/MM/yyyy"));
            Console.WriteLine(dateinput.ToString("yyyy/MM/dd"));
            Console.WriteLine(dateinput.ToString("MM/yyyy"));
            Console.WriteLine(dateinput.ToString("MM-yyyy"));
        }

        /// <summary>
        /// Input: 1 ngày.h
        ///Hiển thị 10 ngày trước là thứ mấy

        /// </summary>
        public static DayOfWeek Method7(DateTime dateinput)
        {
            DateTime tenDayslater = dateinput.AddDays(10);
            return tenDayslater.DayOfWeek;
        }

        /// <summary>
        /// Input: 1 ngày.
        ///Hiển thị cuối tháng này là thứ mấy

        /// </summary>
        public static DayOfWeek Method8(DateTime dateinput)
        {
            DateTime endOfMonth = new DateTime(dateinput.Year, dateinput.Month, DateTime.DaysInMonth(dateinput.Year, dateinput.Month));
            return endOfMonth.DayOfWeek;

        }
        /// <summary>
        /// Input: 1 ngày.
        ///Hiển thị cuối năm nay là thứ mấy

        /// </summary>
        public static DayOfWeek Method10(DateTime dateinput)
        {
            DateTime endOfYear = new DateTime(dateinput.Year, 12, DateTime.DaysInMonth(dateinput.Year, 12));
            return endOfYear.DayOfWeek;

        }

        /// <summary>
        /// Input: 2 ngày.
        ///Hiển thị 2 ngày này cách nhau bao nhiêu ngày

        /// </summary>
        public static int Method11(DateTime dateinput, DateTime dateinput2)
        {
            return Math.Abs((dateinput - dateinput2).Days);
        }
        public static void HandleCase(int option)
        {
            switch (option)
            {
                case 1:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(DateTime.Now));
                    break;
                case 2:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(Helper.InputDateTime()));
                    break;
                case 3:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(Helper.InputDateTime().AddDays(1)));
                    break;
                case 4:
                    Console.WriteLine(Helper.ConvertToVietnameseDate(Helper.InputDateTime().AddDays(-1)));
                    break;
                case 5:
                    Method5(Helper.InputDateTime());
                    break;
                case 6:
                    Method6(Helper.InputDateTime());
                    break;
                case 7:
                    Method7(Helper.InputDateTime());
                    break;
                case 8:
                    Method8(Helper.InputDateTime());
                    break;
                case 10:
                    Method10(Helper.InputDateTime());
                    break;
                case 11:
                    dynamic inputs = Helper.Input2Datetime();
                    Method11(inputs.input1, inputs.input2);
                    break;

            }
        }
    }
}
