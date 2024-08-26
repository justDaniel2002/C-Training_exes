using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.Collection
{
    internal class _List
    {
        public static void Menu()
        {
            Console.WriteLine("1.danh sách 10 số bất kỳ" +
                "\n2.danh sách 10 số bất kỳ" +
                "\n3.danh sách 10 số bất kỳ,Sắp xếp danh sách theo thứ tự tăng dần" +
                "\n4.danh sách 10 số bất kỳ, Đảo ngược vị trí các số trong danh sách" +
                "\n5.danh sách 10 số bất kỳ, Bỏ đi các số nhỏ hơn X khỏi danh sách" +
                "\n6.danh sách 10 số bất kỳ, Bỏ đi các số chia hết cho X khỏi danh sách" +
                "\n7.danh sách 10 số bất kỳ và 1 số lớn hơn 0, In X số cuối ra màn hình" +
                "\n8.danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình theo chiều ngược lại\r" +
                "\n9.Input: 1 số lớn hơn 0 (X)\r\nTính dãy Fibonaci của số nhập vào\r\nIn 10 giá trị kết quả ra màn hình\r\n");
        }


        public static void HandleCase(int option)
        {
            switch(option)
            {
                case 1:
                    printList(AddNumberList());
                    break;
                case 2:
                    printList(orderAsc(AddNumberList()));
                    break;
                case 3:
                    printList(reverse(AddNumberList()));
                    break;
                case 4:
                    printList(filterSmallerThanX(AddNumberList(), Helper.inputInt()));
                    break;
                case 5:
                    printList(filterDividedX(AddNumberList(), Helper.inputInt()));
                    break;
                case 6:
                    printList(method6(AddNumberList(), Helper.inputInt()));
                    break;
                case 7:
                    method7(AddNumberList(), Helper.inputInt());
                    break;
                case 8:
                    method8(AddNumberList(), Helper.inputInt());
                    break;
            }
        }

        public static List<int> AddNumberList()
        {
            var list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                Console.Write("Nhập vào list ");
                list.Add(Helper.inputInt());
            }
            return list;
        }

        public static void printList(List<int> list)
        {
            Console.WriteLine(list.ToString());
        }

        public static List<int> orderAsc(List<int> list)
        {
            list.Sort();
            return list;
        }

        public static List<int> reverse(List<int> list)
        {
            list.Reverse();
            return list;
        }

        public static List<int> filterSmallerThanX(List<int> list, int x)
        {
            return list.Where(n => n > x).ToList();
        }

        public static List<int> filterDividedX(List<int> list, int x)
        {
            return list.Where(n => n % x != 0).ToList();
        }
        public static List<int> method6(List<int> list, int x)
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

        public static void method7(List<int> list, int x)
        {
            if(x > list.Count)
            {
                Console.WriteLine("số nhập vào lớn hơn độ dài danh sách");
                return;
            }
            for (int i = list.Count-x; i < list.Count; i++)
            {
                if (list[i] < x)
                {
                    Console.WriteLine(list[i]);
                }
            }

        }

        public static void method8(List<int> list, int x)
        {
            if (x > list.Count)
            {
                Console.WriteLine("số nhập vào lớn hơn độ dài danh sách");
                return;
            }

            list.Reverse();
            for (int i = 0; i < x; i++)
            {
                if (list[i] < x)
                {
                    Console.WriteLine(list[i]);
                }
            }

        }

        public static List<int> getFibo(int x, List<int>? fiboList=null)
        {
            if (x == 0) return fiboList;

            if (fiboList == null) fiboList = new List<int>();

            if (fiboList.Count == 0 || fiboList.Count == 1) fiboList.Add(1);

            else if (fiboList.Count >= 2)
            {
                fiboList.Add(fiboList[fiboList.Count - 1] + fiboList[fiboList.Count - 2]);
            }

            return getFibo(x--, fiboList);
        }
    }
}
