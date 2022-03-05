using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Fraction fraction = new Fraction();
        }

        class Fraction
        {
            private int counter = 0;
            private int denominator = 0;

            public Fraction() 
            {
                counter = 20;
                denominator = 45;
                Console.WriteLine("Konstuktor domyślny");
            }

            public Fraction(int a, int b)
            {
                counter = a;
                denominator = b;
                Console.WriteLine(counter.ToString());
                Console.WriteLine(counter + denominator);
                Console.WriteLine(counter - denominator);
                Console.WriteLine(counter * denominator);
                Console.WriteLine(counter / denominator);
            }

           public Fraction(Fraction previousFraction)
            {
                counter = previousFraction.counter;
                denominator = previousFraction.denominator;
            }
    }
    }
}
