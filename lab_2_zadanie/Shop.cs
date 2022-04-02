using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Shop : IThing
    {
        private String name;
        private Person[] people;
        private Product[] products;

        public String Name { get; set; }

        public Shop(String name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            String result = "Shop: Super Market\n-- People: --";
            Console.WriteLine(result);
            foreach(Person people in this.people)
            {
                people.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (Product product in this.products)
            {
                product.Print("\t");
            }
        }
    }
}
