using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {
            
        }

        public void AddProduct(Product product)
        {
            this.tasks.Add(product);
        }

        public void RemoveProduct (int index)
        {
            
        }
            
        public override void Print(String prefix)
        {
            Console.WriteLine(prefix + "Buyer: " + this.Name +  " (" + this.Age + " y.o. )");
            if (this.tasks.Count > 0)
            {
                Console.WriteLine("\t\t-- Products: --");
            }
            foreach (Product product in this.tasks)
            {
                Console.Write("\t");
                product.Print("\t");
            }
        }
        
    }
}
