
using System.Text;
using Traning_exes_console.Collection;
using Traning_exes_console.Condition;
using Traning_exes_console.File;
using Traning_exes_console.LinQ;
using Traning_exes_console.Object;
using Traning_exes_console.PrimitiveTypes;


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
                int option = Helper.inputInt();
                switch(option)
                {
                    case 1:
                        _String.Menu();
                        int StrOption = Helper.inputInt();
                        _String.HandleCase(StrOption);
                        break;
                    case 2:
                        _Int.Menu();
                        int intOption = Helper.inputInt();
                        _Int.HandleCase(intOption);
                        break;
                    case 3:
                        _Datetime.Menu();
                        int dtOption = Helper.inputInt();
                        _Datetime.HandleCase(dtOption);
                        break;
                    case 4:
                        _List.Menu();
                        int listOption = Helper.inputInt();
                        _List.HandleCase(listOption);
                        break;
                    case 5:
                        _Dictionary.Menu();
                        int dictOption = Helper.inputInt();
                        _Dictionary.HandleCase(dictOption);
                        break;
                    case 6:
                        PersonManager.Menu();
                        int perOption = Helper.inputInt();
                        PersonManager.HandleCase(perOption);
                        break;
                    case 7:
                        FileHandle.StartUp();
                        FileHandle.Menu();
                        int fOption = Helper.inputInt();
                        FileHandle.HandleCase(fOption);
                        break;
                    case 8:
                        _LinQ.Menu();
                        int linQOption = Helper.inputInt();
                        _LinQ.HandleCase(linQOption);
                        break;
                    case 9:
                        _Condition.Menu();
                        int conption = Helper.inputInt();
                        _Condition.HandleCase(conption);
                        break;


                }
            }

            

        }
    
        
    }
}
