using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Deck of Cards Assignment 4
             * Andrew Conniff
             */
            string pokerYesOrNo;
            bool keepPlaying = true;
            Dealer x = new Dealer();

            Console.WriteLine("******Poker Hands******");

            //Game Controls: play, quit or game over
            while (keepPlaying && (x.GetNumberOfCardsRemaining() > 5))
            {
                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("Deal next hand? ");
                pokerYesOrNo = Console.ReadLine();
                
                string answer = pokerYesOrNo.ToUpper();

                if (answer == "Y" || answer == "YES")
                {
                    Console.WriteLine("");

                    Console.WriteLine("");

                    Deck d = new Deck();
                    //   Hand testing = new Hand(a1s, a2s, a3s, a4s, a5s);
                    x.DealHand();
                    Console.WriteLine("");
                    Console.WriteLine("There are {0} cards left in the deck.", x.GetNumberOfCardsRemaining());
                          

                }
                else if (answer == "N" || answer == "No")
                {

                    Console.WriteLine("Thanks for playing!");
                    keepPlaying = false;
                   
                }
                else
                {

                    Console.WriteLine("Thanks for playing!");
                    keepPlaying = false;

                }

            }
            if ( x.GetNumberOfCardsRemaining() < 5 )
            {
                Console.WriteLine("Thanks for playing!");
                Console.ReadKey();

            }

            Console.ReadKey();
        }

    }
}
