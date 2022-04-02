using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Fruit : Product
    {
        private int count;

        public int Count { get { return count; } set { count = value; } }

        public Fruit(String name, int count) : base(name)
        {
            this.Count = count;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + this.Name + "(" + this.Count + " fruits)");
        }
    }
}
