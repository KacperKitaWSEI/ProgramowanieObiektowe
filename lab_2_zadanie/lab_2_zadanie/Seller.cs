using System;
namespace lab_2_zadanie
{
    public class Seller: Person
    {
        public Seller()
        {
        }

        public Seller(string name, int age) : base(name,age)
        {

        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + "Seller: " + this.name + " (" + this.age.ToString() + " y.o.)");
        }
    }
}
