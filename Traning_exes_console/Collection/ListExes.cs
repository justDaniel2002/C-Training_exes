using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.Collection
{
    //todo: Chuyển hàm về dạng input, output
    //todo: Kiểm tra lại quy tắc đặt tên hàm, biến
    //todo: Áp dụng Exception cho các bài tập có so sánh giá trị không hợp lệ
    internal class ListExes
    {
        public static void Menu()
        {
            Console.WriteLine("1.danh sách 10 số bất kỳ" +
                "\n2.danh sách 10 số bất kỳ, Sắp xếp danh sách theo thứ tự tăng dần" +
                "\n3.danh sách 10 số bất kỳ, Đảo ngược vị trí các số trong danh sách" +
                "\n4.danh sách 10 số bất kỳ, Bỏ đi các số nhỏ hơn X khỏi danh sách" +
                "\n5.danh sách 10 số bất kỳ, Bỏ đi các số chia hết cho X khỏi danh sách" +
                "\n6.danh sách 10 số bất kỳ, Với mỗi số trong danh sách, nếu nhỏ hơn X thì cộng với X" +
                "\n7.danh sách 10 số bất kỳ và 1 số lớn hơn 0, In X số cuối ra màn hình" +
                "\n8.danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình theo chiều ngược lại\r" +
                "\n9.Input: 1 số lớn hơn 0 (X)\r\nTính dãy Fibonaci của số nhập vào\r\nIn 10 giá trị kết quả ra màn hình\r\n");
        }


        public static void HandleCase(int option)
        {
            switch(option)
            {
                case 1:
                    PrintList(AddNumberList());
                    break;
                case 2:
                    PrintList(OrderAsc(AddNumberList()));
                    break;
                case 3:
                    PrintList(Reverse(AddNumberList()));
                    break;
                case 4:
                    PrintList(FilterSmallerThanX(AddNumberList(), Helper.InputInt()));
                    break;
                case 5:
                    PrintList(FilterDividedX(AddNumberList(), Helper.InputInt()));
                    break;
                case 6:
                    PrintList(Method6(AddNumberList(), Helper.InputInt()));
                    break;
                case 7:
                    Method7(AddNumberList(), Helper.InputInt());
                    break;
                case 8:
                    Method8(AddNumberList(), Helper.InputInt());
                    break;
                case 9:
                    PrintList(GetFibo(Helper.InputInt()));
                    break;

            }
        }

        /// <summary>
        /// Tạo 1 danh sách số int
        ///Thêm vào danh sách 10 số bất kỳ

        /// </summary>
        public static List<int> AddNumberList()
        {
            var list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Nhập vào list ");
                list.Add(Helper.InputInt());
            }
            return list;
        }

        /// <summary>
        /// in kết quả ra màn hình 
        /// </summary>
        public static void PrintList(List<int> list)
        {
            Console.WriteLine("Danh sách: ");
           foreach(int i in list) Console.Write(i+" ");
           Console.WriteLine();
        }

        /// <summary>
        /// Sắp xếp danh sách theo thứ tự tăng dần
        /// </summary>
        public static List<int> OrderAsc(List<int> list)
        {
            list.Sort();
            return list;
        }

        /// <summary>
        /// Đảo ngược vị trí các số trong danh sách
        /// </summary>
        public static List<int> Reverse(List<int> list)
        {
            list.Reverse();
            return list;
        }

        /// <summary>
        /// Bỏ đi các số nhỏ hơn X khỏi danh sách
        /// </summary>
        public static List<int> FilterSmallerThanX(List<int> list, int x)
        {
            return list.Where(n => n > x).ToList();
        }

        /// <summary>
        /// Bỏ đi các số chia hết cho X khỏi danh sách
        /// </summary>
        public static List<int> FilterDividedX(List<int> list, int x)
        {
            return list.Where(n => n % x != 0).ToList();
        }

        /// <summary>
        /// Input: danh sách 10 số bất kỳ và 1 số (X)
        ///Với mỗi số trong danh sách, nếu nhỏ hơn X thì cộng với X
        ///In kết quả ra màn hình

        /// </summary>
        public static List<int> Method6(List<int> list, int x)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i] < x)
                {
                    list[i] += x;
                }
            }

            return list;
        }

        /// <summary>
        /// Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)
        ///In X số cuối ra màn hình

        /// </summary>
        public static void Method7(List<int> list, int x)
        {
            if(x > list.Count)
            {
                Console.WriteLine("số nhập vào lớn hơn độ dài danh sách");
                return;
            }
            for (int i = list.Count-x; i < list.Count; i++)
            {                
                    Console.Write(list[i]+" ");                
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)
        ///In X số cuối ra màn hình theo chiều ngược lại

        /// </summary>

        public static void Method8(List<int> list, int x)
        {
            if (x > list.Count)
            {
                Console.WriteLine("số nhập vào lớn hơn độ dài danh sách");
                return;
            }

            list.Reverse();
            for (int i = 0; i < x; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

        }

        /// <summary>
        /// Input: 1 số lớn hơn 0 (X)
        ///Tính dãy Fibonaci của số nhập vào
        ///In 10 giá trị kết quả ra màn hình
        ///Trả về dãy đã tạo

        /// </summary>>
        public static List<int> GetFibo(int x, List<int>? fiboList=null)
        {
            int loop = 10;

            while (loop != 0)
            {
                if (fiboList == null) fiboList = new List<int>();

                if (fiboList.Count == 0 || fiboList.Count == 1) fiboList.Add(x);

                else if (fiboList.Count >= 2)
                {
                    fiboList.Add(fiboList[fiboList.Count - 1] + fiboList[fiboList.Count - 2]);
                }

                loop--;
            }

            return fiboList;
        }
    }
}
