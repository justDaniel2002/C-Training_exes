using System.Text.RegularExpressions;

namespace Traning_exes_console.PrimitiveTypes
{
    //todo: Chuyển hàm về dạng input, output
    //todo: Kiểm tra lại quy tắc đặt tên hàm, biến
    //todo: Tìm hiểu sử dụng string.Equals cho các bài tập so sánh chuỗi hoa thường
    internal class StringExes
    {
        public static string spaceRegex = @"\s+";

        /// <summary>
        ///Input: 1 chuỗi.
        ///Nếu chuỗi null -> Thông báo: Chuỗi bị null
        ///Nếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng
        ///Nếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space
        /// </summary>
        public static bool BaseMethod(string str)
        {
            if (str == null)
            {
                Console.WriteLine("Chuỗi bị null");
                return false;
            }
            else if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Chuỗi rỗng");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Chuỗi space");
                return false;
            }
          
            return true;
        }
        /// <summary>
        /// In chuỗi ký tự ra màn hình
        /// </summary>
        public static string Method1(string str)
        {
            if(BaseMethod(str)) Console.WriteLine(str);

            return str;
        }

        /// <summary>
        /// In chuỗi ký tự sau khi bỏ ký tự trắng ở đầu và cuối
        /// </summary>
        public static string Method2(string str)
        {

            if (BaseMethod(str)) Console.WriteLine(str.Trim());
            return str;

        }

        /// <summary>
        /// In chuỗi ký tự sau khi bỏ hết ký tự trắng
        /// </summary>
        public static string Method3(string str)
        {

            if (BaseMethod(str))  Console.WriteLine(Regex.Replace(str, spaceRegex, ""));
            return str;

        }

        /// <summary>
        /// In chuỗi ký tự sau khi chuyển thành chữ hoa các ký tự đứng sau dấu Space
        /// </summary>
        public static string Method4(string str)
        {
            string finalStr = "";
            if (BaseMethod(str))
            {
                string[] words = Regex.Split(str, spaceRegex);
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = Regex.Replace(words[i], @"\b\w", match => match.Value.ToUpper());
                }


                foreach (string word in words)
                {
                    finalStr += word + " ";
                }

                Console.WriteLine(finalStr.Trim());
            }
                
            return finalStr;

        }

        /// <summary>
        /// Đếm và thông báo số ký tự Space
        /// </summary>
        public static string Method5(string str)
        {
            if (BaseMethod(str))
            {
                string[] words = Regex.Split(str, spaceRegex);

                Console.WriteLine($"có {words.Count() - 1} ký tự space");
            }

            return str;

        }

        /// <summary>
        /// Đếm và thông báo số ký tự không phải Space
        /// </summary>
        public static string Method6(string str)
        {
            if (BaseMethod(str))
            {
                string strWithOutSpace = Regex.Replace(str, spaceRegex, "");
                Console.WriteLine($"có {strWithOutSpace.Count()} ký tự không phải space");
            }

            return str;

        }

        /// <summary>
        /// Input: 2 chuỗi đầu vào (input1, input2)
        //Nếu 2 chuỗi giống nhau(Phân biệt hoa thường) -> Hiển thị kết quả: Chuỗi[input1] giống chuỗi[input2]
        //Ngược lại, Hiển thị kết quả: Chuỗi "input1"khác chuỗi "input2"

        /// </summary>
        public static void Method7(string input1, string input2)
        {
            //string.Equals
            if (string.Equals(input1, input2, StringComparison.Ordinal))
            {
                Console.WriteLine($"Chuỗi {input1} giống chuỗi {input2}");
            }
            else
            {
                Console.WriteLine($"Chuỗi {input1} khác chuỗi {input2}");
            }
        }

        /// <summary>
        /// Input: 2 chuỗi đầu vào (input1, input2)
        ///Nếu 2 chuỗi giống nhau(Không phân biệt hoa thường) -> Hiển thị kết quả: Chuỗi[input1] giống chuỗi[input2]
        ///Ngược lại, Hiển thị kết quả: Chuỗi "input1"khác chuỗi "input2"

        /// </summary>
        public static void Method8(string input1, string input2)
        {
            //string.Equals
            if (string.Equals(input1, input2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Chuỗi {input1} giống chuỗi {input2}");
            }
            else
            {
                Console.WriteLine($"Chuỗi {input1} khác chuỗi {input2}");
            }
        }

        /// <summary>
        /// Thay thếcác đoạn "ABC" có trong chuỗi đầu vào bằng "DEF", CÓ phân biệt hoa thường
        /// </summary>
        public static string Method9(string input1)
        {
            if (BaseMethod(input1))
            {

                input1 = input1.Replace("ABC", "DEF");
                Console.WriteLine(input1);
            }

            return input1;
        }

        /// <summary>
        /// Hiển thị chuỗi: Kính chào ông input. Chúc ngon miệng.
        /// (Giả sử input = "Vũ Văn Chiến"-> "Kính chào ông Vũ Văn Chiến. Chúc ngon miệng.") 

        /// </summary>
        public static string Method10(string input)
        {
            if (BaseMethod(input)) Console.WriteLine($"Kính chào ông {input}, Chúc ngon miệng");

            return input;
        }

        /// <summary>
        /// Đảo ngược các ký tự của chuỗi và in ra màn hình chuỗi đầu vào và chuỗi kết quả
        /// </summary>
        public static string Method11(string str)
        {
            string reversed = "";
            if (BaseMethod(str))
            {
                reversed = new string(str.Reverse().ToArray());
                Console.WriteLine(reversed);
            }
            return reversed;
        }

        /// <summary>
        /// Input: 1 chuỗi và 1 số (count)
        /// Nếu chuỗi null -> Thông báo: Chuỗi bị null
        /// Nếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng
        /// Nếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space
        /// Nếu số< 0 -> Thông báo: Số nhỏ hơn 0
        /// Còn lại: Bỏ các ký tự trắng ở đầu chuỗi, cắt lấycount ký tự ĐẦU và in kết quả ra màn hình

        /// </summary>
        public static void Method12(string str, int num)
        {
            bool validStr = BaseMethod(str);

            if (num < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
            }
            else if (num > str.Length)
            {
                Console.WriteLine("Số lớn hơn độ dài str");
            }
            else if (validStr)
            {
                str = str.TrimStart();
                Console.WriteLine(str.Substring(0, num));
            }
        }


        /// <summary>
        /// Input: 1 chuỗi và 1 số (count)
        /// Nếu chuỗi null -> Thông báo: Chuỗi bị null
        /// Nếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng
        /// Nếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space
        /// Nếu số< 0 -> Thông báo: Số nhỏ hơn 0
        /// Còn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự ĐẦU và in kết quả ra màn hình

        /// </summary>
        public static void Method13(string str, int num)
        {
            bool validStr = BaseMethod(str);

            if (num < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
            }
            else if (num > str.Length)
            {
                Console.WriteLine("Số lớn hơn độ dài str");
            }
            else if (validStr)
            {
                str = str.Trim();
                Console.WriteLine(str.Substring(0, num));
            }
        }


        /// <summary>
        /// Input: 1 chuỗi và 1 số (count)
        /// Nếu chuỗi null -> Thông báo: Chuỗi bị null
        /// Nếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng
        /// Nếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space
        /// Nếu số< 0 -> Thông báo: Số nhỏ hơn 0
        /// Còn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự CUỐI và in kết quả ra màn hình
        /// </summary>
        public static void Method14(string str, int num)
        {
            bool validStr = BaseMethod(str);

            if (num < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0");
            }
            else if (num > str.Length)
            {
                Console.WriteLine("Số lớn hơn độ dài str");
            }
            else if (validStr)
            {
                str = str.Trim();
                Console.WriteLine(str.Substring(str.Length - num, num));
            }
        }


        public static void Menu()
        {
            Console.WriteLine("1.1 input một chuỗi" +
                   "\n1.2 input một chuỗi, In chuỗi ký tự sau khi bỏ ký tự trắng ở đầu và cuối" +
                   "\n1.3 input một chuỗi, In chuỗi ký tự sau khi bỏ hết ký tự trắng" +
                   "\n1.4 input một chuỗi, In chuỗi ký tự sau khi chuyển thành chữ hoa các ký tự đứng sau dấu Space" +
                   "\n1.5 input một chuỗi, Đếm và thông báo số ký tự Space" +
                   "\n1.6 input một chuỗi, Đếm và thông báo số ký tự không phải Space" +
                   "\n1.7 Input: 2 chuỗi đầu vào" +
                   "\n1.8 Input: 2 chuỗi đầu vào, nhưng không phân biệt hoa thường" +
                   "\n1.9 input một chuỗi, Thay thếcác đoạn \"ABC\" có trong chuỗi đầu vào bằng \"DEF\", CÓ phân biệt hoa thường" +
                   "\n1.10 input một chuỗi, Hiển thị chuỗi: Kính chào ông input. Chúc ngon miệng" +
                   "\n1.11 input một chuỗi, Đảo ngược các ký tự của chuỗi và in ra màn hình chuỗi đầu vào và chuỗi kết quả" +
                   "\n1.12 Input: 1 chuỗi và 1 số" +
                   "\n1.13 Input: 1 chuỗi và 1 số, Còn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự ĐẦU và in kết quả ra màn hình" +
                   "\n1.14 Input: 1 chuỗi và 1 số, Còn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự CUỐI và in kết quả ra màn hình");

            Console.Write("option (1-14): ");
        }


        public static void HandleCase(int option)
        {
            dynamic inputs = null;
            switch (option)
            {
                case 1:
                    //1.1
                    Method1(Helper.InputStr());
                    break;
                case 2:
                    //1.2
                    Method2(Helper.InputStr());
                    break;
                case 3:
                    //1.3
                    Method3(Helper.InputStr());
                    break;
                case 4:
                    //1.4
                    Method4(Helper.InputStr());
                    break;
                case 5:
                    //1.5
                    Method5(Helper.InputStr());
                    break;
                case 6:
                    //1.6
                    Method6(Helper.InputStr());
                    break;
                case 7:
                    inputs = Helper.Input2Str();
                    //1.1.7
                    Method7(inputs.input1, inputs.input2);
                    break;
                case 8:
                    inputs = Helper.Input2Str();
                    //1.1.8
                    Method8(inputs.input1, inputs.input2);
                    break;
                case 9:
                    //1.1.9
                    Method9(Helper.InputStr());
                    break;
                case 10:
                    //1.1.10
                    Method10(Helper.InputStr());
                    break;
                case 11:
                    //1.1.11
                    Method11(Helper.InputStr());
                    break;
                case 12:
                    //1.1.12
                    Method12(Helper.InputStr(), Helper.InputInt());
                    break;
                case 13:
                    //1.1.13
                    Method13(Helper.InputStr(), Helper.InputInt());
                    break;
                case 14:
                    //1.1.14
                    Method14(Helper.InputStr(), Helper.InputInt());
                    break;

            }
        }
    }
}
