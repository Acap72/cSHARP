using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment4
{
    class Card
    {
        //fields 
        int Rank;
        int SuiteCode;
        public Char Suite;
        public string Name;
        public string RankText;

        //Constructor
        public Card(int rank, int suiteCode)
        {
            Rank = rank;
            SuiteCode = suiteCode;

        }

        public string GetName()
        {

            Name = RankText + " of " + Suite;
            return Name;
        }

        public Char GetSuite()
        {
            if (SuiteCode == 1)
            {
                //Spades
                Suite = (Char)6;
            }
            else
                if (SuiteCode == 2)
                {
                    //Clubs
                    Suite = (Char)5;
                }
                else
                    if (SuiteCode == 3)
                    {
                        //Diamonds
                        Suite = (Char)4;
                    }
                    else
                        if (SuiteCode == 4)
                        {
                            //hearts
                            Suite = (Char)3;
                        }
            return Suite;

        }

        public int GetRank()
        {
            if (Rank == 11)
            {
                RankText = "J";
            }
            else
                if (Rank == 12)
                {
                    RankText = "Q";
                }
                else
                    if (Rank == 13)
                    {
                        RankText = "K";
                    }
                    else
                        if (Rank == 1)
                        {
                            RankText = "A";
                        }
                        else
                        {
                            RankText = Rank.ToString(); ;
                        }

            return Rank;
        }


    }
}
