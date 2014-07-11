using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UMass.Assignment5
{
    class RomanCipherWriter : StreamWriter
    {
        Stream StreamLocal;
        Encoding newEncoding;
        int BufferSize;
        String f = " ";
        bool j;
        string FileName;
        int Offset;


        public RomanCipherWriter(string fileName, int offSet)
            : base(fileName)
        {
            FileName = fileName;
            Offset = offSet;
        }

        //for testing the writer
        public RomanCipherWriter(Stream StreamLocal, Encoding newEncoding, int BufferSize, bool j)
            : base(StreamLocal, newEncoding, BufferSize, j)
        {

        }

        public override void Write(string value)
        {
            StringBuilder sb = new StringBuilder(value);
            int length = value.Count();

            List<string> standard = StandardAlphabet.GetStandardAlphabet();
            List<string> compare = CypherAlphabet();
            List<string> compare2 = new List<string>();

            //now that we have a new alphabet make each item
            //lowercase so that we only replace the item once. 
            foreach (var item in compare)
            {
                compare2.Add(item.ToLower());
            }

            //using replace we apply the Roman Cypher
            for (int i = 0; i < 26; i++)
            {
                sb.Replace(standard[i], compare2[i]);
            }

            //  Write the string out to the file,
            base.Write(sb.ToString().ToUpper());
        }

        //Take the standard alphabet and move the letters 
        private List<string> CypherAlphabet()
        {
            StandardAlphabet s1 = new StandardAlphabet();

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
