using System;
namespace lab_2_zadanie
{
    public class Shop: IThing
    {

        protected string name;
        protected Person[] people;
        protected Product[] products;

        public string Name
        {
            get { return name; }
        }

        public Shop()
        {
        }

        public Shop(string name, Person[] people, Product[] products)
        {
            this.name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine("Shop: " + this.name);
            Console.WriteLine("-- People: --");
            foreach (var people in people)
            {
                people.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (var product in products)
            {
                product.Print("\t");
            }

        }
    }
}
