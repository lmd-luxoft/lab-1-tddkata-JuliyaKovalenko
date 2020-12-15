// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SimpleTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }

        [Test]
        public void SumShouldBeCorrect()
        {
            string str = "0,1";
            int expected = 1;

            int actual = Sum(str);
            Assert.That(actual, expected);
        }

        [Test]
        public void SumShouldBeStringIsEmpty()
        {
            string str = "";
            int expected = 0;
            int actual = str.Length;
            Assert.That(expected, actual);

        }

        [Test]
        public void SumShouldBeNotHaveNegative()
        {
            string str = "-1,2,3";
            int expected = -1;
            bool actual = str.Contains("-");

            Assert.That(expected, actual);
        }

        [Test]
        public void SumShoulHaveLessThan3Nubers()
        {
            string str = "1,2,3,4,5";
            int expected = -1;
            int actual = str.Length;

            Assert.That(expected, actual);
        }
    }
}
