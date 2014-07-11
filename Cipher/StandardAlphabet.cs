using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMass.Assignment5
{
    class StandardAlphabet
    {

       static List<string> BaseAlphabet = new List<string>();
       // string NextLetter;
        int Offset = 0; 

        public StandardAlphabet()
        {
            ///Add the base alphabet
            BaseAlphabet.Add("A");
            BaseAlphabet.Add("B");
            BaseAlphabet.Add("C");
            BaseAlphabet.Add("D");
            BaseAlphabet.Add("E");
            BaseAlphabet.Add("F");
            BaseAlphabet.Add("G");
            BaseAlphabet.Add("H");
            BaseAlphabet.Add("I");
            BaseAlphabet.Add("J");
            BaseAlphabet.Add("K");
            BaseAlphabet.Add("L");
            BaseAlphabet.Add("M");
            BaseAlphabet.Add("N");
            BaseAlphabet.Add("O");
            BaseAlphabet.Add("P");
            BaseAlphabet.Add("Q");
            BaseAlphabet.Add("R");
            BaseAlphabet.Add("S");
            BaseAlphabet.Add("T");
            BaseAlphabet.Add("U");
            BaseAlphabet.Add("V");
            BaseAlphabet.Add("W");
            BaseAlphabet.Add("X");
            BaseAlphabet.Add("Y");
            BaseAlphabet.Add("Z");
        }

        public static List<string> GetStandardAlphabet()
        {


            return BaseAlphabet;
        
        }

      
    }
}
