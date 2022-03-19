using System;
namespace Lab1
{
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {

        //subsection 1
        public int counter { get; private set; }//subsection 6
        public int denominator { get; private set; }//subsection 6

        public Fraction()
        {

        }

        public Fraction(int a, int b)
        {
            counter = a;
            denominator = b;
        }

        public Fraction(Fraction previousFraction)
        {
            counter = previousFraction.counter;
            denominator = previousFraction.denominator;
        }
        //subsection 1 stop
        //subsection 3 start
        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.counter, a.denominator);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.counter * b.denominator + b.counter * a.denominator, a.counter * b.denominator);

        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.counter * b.denominator, a.denominator * b.denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.counter == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.counter * b.denominator, a.denominator * b.counter);
        }
        //subsection 3 stop
        //subsection 2 start
        public override string ToString() => $"{counter} / {denominator}";
        //subsection 2 stop
        //subsection 4 start
        public bool Equals(Fraction fraction)
        {
            return counter == fraction.counter && denominator == fraction.denominator;
        }

        public int CompareTo(Fraction other)
        {
            return (this - other).counter;
        }
        //subsection 4 stop
        //subsection 6 start
        public double RoundDown()
        {
            return Math.Floor((double)(counter / denominator));
        }

        public double RoundUp()
        {
            return Math.Ceiling((double)(counter / denominator));
        }

        //subsection 6 stop
    }
}
