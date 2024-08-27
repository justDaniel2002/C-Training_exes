using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Traning_exes_console.File
{
    internal class FileHandle
    {
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static string output_url = "output.txt";
        public static string input_url = "input.txt";

        public static void writeInputFile(string str)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter($"../../../File/{input_url}", append: true))
                {
                    writer.WriteLine(str);
                }
                Console.WriteLine("Ghi ra input file thành công");
            }catch(FileNotFoundException ex)
            {
                FileStream fs = System.IO.File.Create(input_url);
                writeInputFile(str);
            }
        }

        public static void writeOutPutFile(string str)
        {
           
            try
            {
                using (StreamWriter writer = new StreamWriter($"../../../File/{output_url}", append: true))
                {
                    writer.WriteLine(str);
                }
                Console.WriteLine("Ghi kết quả ra output file thành công");
            }
            catch (FileNotFoundException ex)
            {
                FileStream fs = System.IO.File.Create(output_url);
                writeOutPutFile(str);
            }
        }

        public static void readInputFile()
        {
            System.IO.File.WriteAllText($"../../../File/{output_url}", string.Empty);
            using (StreamReader reader = new StreamReader($"../../../File/{input_url}"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = Regex.Replace(line, @"\s+", " ");
                    List<string> words = line.Split(' ').ToList();

                    bool isNumeric = Helper.IsValidNumericString(line);

                    if (!isNumeric)
                    {
                        writeOutPutFile($"Format không đúng: {line}");
                        continue;
                    }

                    List<int> numbers = new List<int>();
                    foreach (var item in words)
                    {
                        try
                        {
                            int num = Int32.Parse(item);
                            numbers.Add(num);
                        }catch(OverflowException ex)
                        {
                            numbers.Add(-1);
                        }
                    }

                    numbers.Sort();

                    var newline = string.Join(" ", numbers);

                    writeOutPutFile(newline);
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine($"1. Ghi vào file {input_url}" +
                $"\n2. Ghi kết quả vào file {output_url}");
        }

        public static void HandleCase(int option)
        {
            switch(option)
            {
                case 1:
                    writeInputFile(Helper.inputStr("input một chuỗi số"));
                    break;
                case 2:
                    readInputFile();
                    break;
            }
        }

        public static void StartUp()
        {
            bool yn = Helper.inputYN("Bạn có muốn sử dụng file mặc định ? Y/N: ");
            if (!yn)
            {
                input_url = Helper.inputStr("nhập tên file input của bạn: ");
                input_url = Helper.inputStr("nhập tên file output của bạn: ");
            }
        }
    }
}
