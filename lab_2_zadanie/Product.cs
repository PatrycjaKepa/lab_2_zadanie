using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Product : IThing
    {
        private String name;

        public String Name { get { return name; } set { name = value; } }

        public Product(String name)
        {
            this.name = name;
        }

        public virtual void Print (string prefix)
        {
            
        }
    }
}
