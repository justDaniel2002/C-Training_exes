using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traning_exes_console.Object
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public DateTime CreatedTime { get; set; }
        public int Order { get; }

        protected int TimeAfter { get; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            Order = 1;
            CreatedTime = DateTime.Now;
        }
        public Person(string Name, int Age, int Order, DateTime firstBorn) { 
            this.Name = Name;
            this.Age = Age;
            this.Order = Order;
            CreatedTime = DateTime.Now;
            TimeAfter = (DateTime.Now - firstBorn).Seconds;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Tôi tên là {Name} {Age} tuổi, tôi là sinh viên");
        }

        public virtual void ExtInfo()
        {
            ShowInfo();
            Console.WriteLine($"Tôi là người thứ {Order} được tạo ra sau người đầu tiên {TimeAfter} giây");
        }

    }
}
