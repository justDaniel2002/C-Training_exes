using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.Object
{
    internal class Teacher : Person
    {
        public Teacher(string Name, int Age) : base(Name, Age)
        {
        }

        public Teacher(string Name, int Age, int Order, DateTime firstBorn) : base(Name, Age, Order, firstBorn)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Tôi tên là {Name} {Age} tuổi, tôi là giáo viên");
        }

        public override void ExtInfo()
        {
            ShowInfo();
            Console.WriteLine($"Tôi là giáo viên thứ {Order} được tạo ra sau giáo viên đầu tiên {TimeAfter} giây");
        }
    }
}
