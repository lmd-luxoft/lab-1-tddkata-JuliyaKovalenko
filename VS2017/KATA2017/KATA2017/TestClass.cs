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
        public void SumShouldBeCorrect()
        {
            string str = "0,1";
            PrapereMassiv massiv = new PrapereMassiv(str);
            StringCalc stringCalc = new StringCalc(massiv);

            int expected = 1;

            int actual = stringCalc.Sum(massiv);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SumShouldBeStringIsEmpty()
        {
            string str = "";
            PrapereMassiv massiv = new PrapereMassiv(str);
            StringCalc stringCalc = new StringCalc(massiv);

            int expected = 0;

            int actual = stringCalc.Sum(massiv);
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void SumShouldBeNotHaveNegative()
        {
            string str = "-1,2,3";
            PrapereMassiv massiv = new PrapereMassiv(str);
            StringCalc stringCalc = new StringCalc(massiv);

            int expected = -1;

            int actual = stringCalc.Sum(massiv);

            Assert.That(actual, Is.EqualTo(expected));
        }



        [Test]
        public void SumCanHaveDifferents2LSeparators()
        {
            string str = "1,4\n5";
            PrapereMassiv massiv = new PrapereMassiv(str);
            StringCalc stringCalc = new StringCalc(massiv);

            int expected = 10;

            int actual = stringCalc.Sum(massiv);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SumShuldBeStartWithSpatialSeparator()
        {

            string str = "//1,4\n5";
            PrapereMassiv massiv = new PrapereMassiv(str);
            StringCalc stringCalc = new StringCalc(massiv);

            int expected = 10;

            int actual = stringCalc.Sum(massiv);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void SumShuldBeStartWithOUTSpatialSeparatorPutFailString()
        {

            string str = "1,4\n5*7.";
            PrapereMassiv massiv = new PrapereMassiv(str);
            StringCalc stringCalc = new StringCalc(massiv);

            int expected = -1;

            int actual = stringCalc.Sum(massiv);

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
