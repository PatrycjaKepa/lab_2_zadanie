using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override void Print(String prefix)
        {
            Console.WriteLine(prefix + "Seller: " + this.Name +" (" + this.Age + " y.o. )");
        }
    }
}
