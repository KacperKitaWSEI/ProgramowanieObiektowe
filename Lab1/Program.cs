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

        class Fraction : IEquatable<Fraction>
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



            public bool Equals(Fraction fraction)
            {
                if (fraction == null)
                {
                    return false;
                }

                if (this.counter == this.denominator)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

    /*       public int CompareTo(object obj)
            {
                if (obj == null)
                {
                    return 0;
                }

                Fraction fraction = obj as Fraction;
                if (fraction != null)
                {
                    return this.
                }
            }

            public double Splitting(int a, int b)
            {
                return a / b;
            }
    */
    }
    }
}
