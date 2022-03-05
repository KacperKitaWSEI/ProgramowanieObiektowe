using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();

            fraction.ToString();
            Console.WriteLine(fraction.counter);
        }

        class Fraction
        {
            public int counter { get; private set; }
            public int denominator { get; private set; }

            public Fraction() 
            {
                counter = 20;
                denominator = 45;
            }

            public Fraction(int a, int b)
            {
                counter = a;
                counter = b;
            }

            public Fraction(Fraction previousFraction)
            {
                counter = previousFraction.counter;
                denominator = previousFraction.denominator;
            }

            public void ToString()
            {
                Console.WriteLine($"{counter}/{denominator}");
            }

    }
    }
}
