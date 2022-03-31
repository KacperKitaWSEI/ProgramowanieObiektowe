using System;
using System.Collections.Generic;

namespace lab_2_zadanie
{
    public class Buyer: Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer()
        {
        }

        public Buyer(string name, int age) : base(name,age)
        {
            
        }

        public void AddProduct(Product product)
        {
            this.tasks.Add(product);
        }

        public void RemoveProduct(int index)
        {
            this.tasks.RemoveAt(index);
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Buyer: " + this.name + " (" + this.age.ToString() + " y.o.)");
            if (tasks.Count > 0)
            {
                Console.WriteLine(prefix + "\t -- Products: --");
                foreach (var products in tasks)
                {
                    products.Print(prefix + "\t");
                }
            }
        }
    }
}
