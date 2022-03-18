using System;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);

            Console.WriteLine(fraction1 / fraction2);
        }

        
    }
}
