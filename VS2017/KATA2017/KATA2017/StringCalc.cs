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

            string[]s2=new string[] { ",", "\n","//","*","." };

            bool IsContains = v.Contains("//");

            

            int[] numbers;

         


            if (IsContains)
            {
                numbers = v.Split(s2, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            else
            {
                
                numbers = v.Split(s, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
           // int[] numbers = v.Split(s, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            

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