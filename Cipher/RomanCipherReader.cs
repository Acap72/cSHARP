using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMass.Assignment5
{
    class RomanCipherReader : StreamReader
    {
        string FileName;
        int Offset;

        public RomanCipherReader(string fileName, int offSet)
            : base(fileName)
        {
            FileName = fileName;
            Offset = offSet;
        }

        public override String ReadToEnd()
        {

            string value = base.ReadToEnd();
            StringBuilder sb = new StringBuilder(value);

            int length = value.Count();

            List<string> standard = StandardAlphabet.GetStandardAlphabet();
            List<string> compare = CypherAlphabet();
            List<string> standard2 = new List<string>();

            //now that we have a new alphabet make each item
            //lowercase IN the REGULAR alphabet 
            //so that we only replace the item once. 
            foreach (var item in standard)
            {
                standard2.Add(item.ToLower());
            }

            //using replace we apply the Roman Cypher
            for (int i = 0; i < 26; i++)
            {
                sb.Replace(compare[i], standard2[i]);
            }

            //Get data in string form
            string d = sb.ToString();

            //show the un encrypted text in teh console window. 
            Console.WriteLine(" ");
            Console.WriteLine("The un-encrypted text from file {0} is... ", FileName);
            Console.WriteLine(d);
            return d;
        }
        private List<string> CypherAlphabet()
        {

            List<string> standard = StandardAlphabet.GetStandardAlphabet();

            //initialize local variable to pick up the count back at 0
            int x = 0;

            List<string> Cyph = new List<string>();
            for (int i = 0; i < standard.Count(); i++)
            {
                if (i < standard.Count() - Offset)
                {
                    Cyph.Add(standard[i + Offset]);
                }
                else
                {
                    Cyph.Add(standard[x]);
                    ++x;
                }
            }

            return Cyph;
        }
    }

}