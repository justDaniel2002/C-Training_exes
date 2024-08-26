
using System.Text;
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
                    "3. Datetime");
                Console.WriteLine("option (1 - 3)");
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
                }
            }

            

        }
    
        
    }
}
