// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string v)
        {

            int Sum = 0;
            
            string[] s = new string[] { ",", "\n" };

           
            //int[] numbers = v.Split(',').Select(int.Parse).ToArray();

            int[] numbers = v.Split(s, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            //if (numbers.Count() > 2)
            //    return -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    return -1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Sum += numbers[i];

            }
            return Sum;
        }
    }
}