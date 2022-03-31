using System;
namespace lab_2_zadanie
{
    public class Meat: Product
    {
        protected double weight;

        public double Weight
        {
            get { return weight; }
        }

        public Meat()
        {
        }

        public Meat(string name, double weight) : base(name)
        {
            this.weight = weight;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + this.name + " (" + this.weight + " kg)");
        }
    }
}
