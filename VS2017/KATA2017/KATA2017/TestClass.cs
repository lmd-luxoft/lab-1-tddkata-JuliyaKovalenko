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
            StringCalc stringCalc = new StringCalc();
            string str = "0,1";
            int expected = 1;

            int actual = stringCalc.Sum(str);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SumShouldBeStringIsEmpty()
        {
            StringCalc stringCalc = new StringCalc();
            string str = "";
            int expected = 0;
            int actual = str.Length;
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void SumShouldBeNotHaveNegative()
        {
            StringCalc stringCalc = new StringCalc();
            string str = "-1,2,3";
            int expected = -1;
            int actual = stringCalc.Sum(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

        //[Test]
        //public void SumShoulHaveLessThan3Nubers()
        //{
        //    StringCalc stringCalc = new StringCalc();
        //    string str = "1,2,3,4,5";
        //    int expected = -1;
        //    int actual = stringCalc.Sum(str);

        //    Assert.That(actual, Is.EqualTo(expected));
        //}

        [Test]
        public void SumCanHaveDifferents2LSeparators()
        {
            StringCalc stringCalc = new StringCalc();
            string str = "1,4\n5";
            int expected = 10;
            int actual = stringCalc.Sum(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SumShuldBeStartWithSpatialSeparator()
        {
            StringCalc stringCalc = new StringCalc();
            string str = "//1,4\n5";
            int expected = 10;
            int actual = stringCalc.Sum(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SumShuldBeStartWithOUTSpatialSeparatorPutFailString()
        {
            StringCalc stringCalc = new StringCalc();
            string str = "1,4\n5*7.";
            int expected = -1;
            int actual = stringCalc.Sum(str);

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
