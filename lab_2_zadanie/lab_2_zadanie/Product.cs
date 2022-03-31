using System;
namespace lab_2_zadanie
{
    public abstract class Product: IThing
    {
        protected string name;

        public string Name
        {
            get { return name; }
        }

        public Product()
        {
        }

        public Product(string name)
        {
            this.name = name;
        }

        public abstract void Print(string prefix);
    }
}
