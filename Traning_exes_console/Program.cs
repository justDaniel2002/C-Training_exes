
using System.Text;
using Traning_exes_console.Collection;
using Traning_exes_console.Condition;
using Traning_exes_console.File;
using Traning_exes_console.LinQ;
using Traning_exes_console.Object;
using Traning_exes_console.PrimitiveTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Traning_exes_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("1. String\n" +
                    "2. Int\n" +
                    "3. Datetime\n" +
                    "4. List\n" +
                    "5. Dictionary\n" +
                    "6. Object\n" +
                    "7. File\n" +
                    "8. LinQ\n" +
                    "9. Condition");
                Console.WriteLine("option (1 - 9)");
                int option = Helper.InputInt();
                switch(option)
                {
                    case 1:
                        StringExes.Menu();
                        int StrOption = Helper.InputInt();
                        StringExes.HandleCase(StrOption);
                        break;
                    case 2:
                        IntExes.Menu();
                        int intOption = Helper.InputInt();
                        IntExes.HandleCase(intOption);
                        break;
                    case 3:
                        DatetimeExes.Menu();
                        int dtOption = Helper.InputInt();
                        DatetimeExes.HandleCase(dtOption);
                        break;
                    case 4:
                        ListExes.Menu();
                        int listOption = Helper.InputInt();
                        ListExes.HandleCase(listOption);
                        break;
                    case 5:
                        DictionaryExes.Menu();
                        int dictOption = Helper.InputInt();
                        DictionaryExes.HandleCase(dictOption);
                        break;
                    case 6:
                        PersonManager.Menu();
                        int perOption = Helper.InputInt();
                        PersonManager.HandleCase(perOption);
                        break;
                    case 7:
                        FileHandle.StartUp();
                        FileHandle.Menu();
                        int fOption = Helper.InputInt();
                        FileHandle.HandleCase(fOption);
                        break;
                    case 8:
                        _LinQ.Menu();
                        int linQOption = Helper.InputInt();
                        _LinQ.HandleCase(linQOption);
                        break;
                    case 9:
                        ConditionExes.Menu();
                        int conption = Helper.InputInt();
                        ConditionExes.HandleCase(conption);
                        break;


                }
            }


            //todo: Tupple Nhập 2 giá trị number, in ra tổng, hiệu 2 số

        }


    }
}
