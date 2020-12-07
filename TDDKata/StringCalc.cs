// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections.Generic;

namespace TDDKata
{
    internal class StringCalc
    {
        internal int Sum(string v)
        {
            string v = "1,2,3";
            int Sum = 0;
            string[] strArr = v.Split(",");
            int[] numArr = new int[strArr.length];
            for (int i = 0; i < numArr.length; i++)
            {
                Sum += numArr[i];

            }
        }
    }
}