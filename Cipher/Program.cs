using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMass.Assignment5
{
    class Program
    {


        static void Main(string[] args)
        {
            string baseName;
            string fileName;
            string textToAdd;
            string textToInt;
            bool isNum;
            int offset;


            Console.WriteLine("****** Roman Cypher ******");

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Enter a name for your new encrypted file: ");
            baseName = Console.ReadLine();

            if (baseName.Contains(".txt"))
            {
                fileName = baseName;
            }
            else
            {
                fileName = baseName + ".txt";
            }

            Console.WriteLine(" ");
            Console.WriteLine(" "); ;

            Console.Write("Enter the text you want to encrypt: ");
            textToAdd = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Enter a number from 1 to 25 get this going: ");
            textToInt = Console.ReadLine();

            isNum = int.TryParse(textToInt, out offset);

            //use good data or exit
            if (isNum && (offset > 0 && offset < 26))
            {

                using (RomanCipherWriter writer = new RomanCipherWriter(fileName, offset))
                {
                    writer.Write(textToAdd.ToUpper());
                    writer.Close();
                }

                //show encrypted text from file in console
                using (StreamReader standardReader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = standardReader.ReadLine()) != null)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("The encrypted text from file {0} is... ", fileName);
                        Console.WriteLine(line);
                       
                    }
                    standardReader.Close();
                }

                //send the file name and offest to the RomanCipherReader
                using (RomanCipherReader reader = new RomanCipherReader(fileName, offset))
                {
                    reader.ReadToEnd();
                    reader.Close();
                }

                
            }
                //exit
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.Write("Maybe next time! Thanks! ");
            }

            Console.ReadKey();
        }
    }
}
