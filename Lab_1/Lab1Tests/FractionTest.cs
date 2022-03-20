using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;


namespace Lab1Tests
{
    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        public void TestContructors()
        {
            var fraction1 = new Fraction();
            Assert.AreEqual(fraction1.counter, 0);
            Assert.AreEqual(fraction1.denominator, 0);

            var fraction2 = new Fraction(1, 2);
            Assert.AreEqual(fraction2.counter, 1);
            Assert.AreEqual(fraction2.denominator, 2);

            var fraction3 = new Fraction(fraction2);
            Assert.AreEqual(fraction3.counter, 1);
            Assert.AreEqual(fraction3.denominator, 2);
        }

        [TestMethod]
        public void TestToString()
        {
            var fraction = new Fraction(1, 2);
            Assert.AreEqual(fraction.ToString(), "1 / 2");
        }
        [TestMethod]
        public void TestPlusOperator()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);
            Assert.AreEqual((fraction1 + fraction2).Equals(new Fraction(5, 3)), true);
        }

        [TestMethod]
        public void TestMinusOperator()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);
            Assert.AreEqual((fraction1 - fraction2).Equals(new Fraction(1, 3)), true);
        }

        [TestMethod]
        public void TestMultiplicationOperator()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);
            Assert.AreEqual((fraction1 * fraction2).Equals(new Fraction(3, 6)), true);
        }

        [TestMethod]
        public void TestDivisionOperator()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);
            Assert.AreEqual((fraction1 / fraction2).Equals(new Fraction(3, 2)), true);
        }

        [TestMethod]
        public void TestEquals()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);
            Assert.IsFalse(fraction1.Equals(fraction2));
        }

        [TestMethod]
        public void TestComparable()
        {
            var fraction1 = new Fraction(1, 2);
            var fraction2 = new Fraction(1, 3);
            Assert.AreEqual(fraction1.CompareTo(fraction2), 1);
        }

        [TestMethod]
        public void RoundDown()
        {
            var fraction1 = new Fraction(1, 2);
            Assert.AreEqual(fraction1.RoundDown(), 0);
        }

        public void RoundUp()
        {
            var fraction1 = new Fraction(1, 2);
            Assert.AreEqual(fraction1.RoundUp(), 0);
        }
    }
}
