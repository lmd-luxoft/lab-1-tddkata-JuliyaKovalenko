// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDKata
{
    internal class StringCalc
    {
        private PrapereMassiv __massiv;
        public StringCalc(PrapereMassiv massiv)
        {
            __massiv = massiv;
        }

        public int Sum(PrapereMassiv massiv)
        {
            int summa = 0;
            int[] result = massiv.massivePraparation(massiv.Str);


            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 0)
                    return -1;
            }


            for (int i = 0; i < result.Length; i++)
            {
                summa += result[i];
            }
            return summa;
        }

    }
    internal class PrapereMassiv
    {
        private string __str;
        public PrapereMassiv(string str)
        {
            __str = str;

        }
        public string Str
        {
            get { return __str; }
            set { __str = value; }

        }

        public string[] ChoosePattern(string str)
        {
            string[] result;

            if (str.StartsWith("//"))
                result = new string[] { ",", "\n", "//", "*", "." };
            else
                result = new string[] { ",", "\n" };

            return result;

        }

        public int[] massivePraparation(string str)
        {
            int[] result;
            string[] separator = ChoosePattern(str);

            // we have for exampls "1,4\n5*7.";
            //in such cases we have to return-1, in  his code it will be in the Sume(it is reiceiving negative 
            //number and in the Sum in Such case we return -1
            try
            {
                result = str.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            catch
            {
                result = new int[] { -1 };
            }

            return result;
        }

    }


}
