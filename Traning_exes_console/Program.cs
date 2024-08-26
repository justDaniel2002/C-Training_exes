
using System.Text;
using Traning_exes_console.PrimitiveTypes;


namespace Traning_exes_console
{   class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
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
                int option = inputInt();
                dynamic inputs = null;
                switch (option)
                {
                    case 1:
                        //1.1
                        _String.baseMedthod(inputStr(),_String.method1);
                        break;
                    case 2:
                        //1.2
                        _String.baseMedthod(inputStr(), _String.method2);
                        break;
                    case 3:
                        //1.3
                        _String.baseMedthod(inputStr(), _String.method3);
                        break;
                    case 4:
                        //1.4
                        _String.baseMedthod(inputStr(), _String.method4);
                        break;
                    case 5:
                        //1.5
                        _String.baseMedthod(inputStr(), _String.method5);
                        break;
                    case 6:
                        //1.6
                        _String.baseMedthod(inputStr(), _String.method6);
                        break;
                    case 7:
                        inputs = input2Str();
                        //1.1.7
                        _String.method7(inputs.input1, inputs.input2);
                        break;
                    case 8:
                        inputs = input2Str();
                        //1.1.8
                        _String.method8(inputs.input1, inputs.input2);
                        break;
                    case 9:
                        //1.1.9
                        _String.baseMedthod(inputStr(), _String.method9);
                        break;
                    case 10:
                        //1.1.10
                        _String.baseMedthod(inputStr(), _String.method10);
                        break;
                    case 11:
                        //1.1.11
                        _String.baseMedthod(inputStr(), _String.method11);
                        break;
                    case 12:
                        //1.1.12
                        _String.method12(inputStr(), inputInt());
                        break;
                    case 13:
                        //1.1.13
                        _String.method13(inputStr(), inputInt());
                        break;
                    case 14:
                        //1.1.14
                        _String.method14(inputStr(), inputInt());
                        break;

                }
                
            }

            

        }
    
        static string inputStr()
        {
            Console.WriteLine("Input một chuỗi: ");
            string str = Console.ReadLine();
            return str;
        }

        static dynamic input2Str()
        {
            Console.WriteLine("Input hai chuỗi: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            return new { input1, input2 };
        }

        static int inputInt()
        {
            Console.WriteLine("Input một số: ");
            string str = Console.ReadLine();
            try
            {
                int num = Int32.Parse(str);
                return num;
            }catch (Exception ex)
            {
                return inputInt();
            }
        }
    }
}
