using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace UML.Assignment4
{
    class Deck
    {
        bool IsInShuffledDeck = false;
        // 52 cards 
        //Spades = 1
        Card a1s = new Card(1, 1);
        Card a2s = new Card(2, 1);
        Card a3s = new Card(3, 1);
        Card a4s = new Card(4, 1);
        Card a5s = new Card(5, 1);
        Card a6s = new Card(6, 1);
        Card a7s = new Card(7, 1);
        Card a8s = new Card(8, 1);
        Card a9s = new Card(9, 1);
        Card a10s = new Card(10, 1);
        Card a11s = new Card(11, 1);
        Card a12s = new Card(12, 1);
        Card a13s = new Card(13, 1);

        // hearts
        Card a1h = new Card(1, 4);
        Card a2h = new Card(2, 4);
        Card a3h = new Card(3, 4);
        Card a4h = new Card(4, 4);
        Card a5h = new Card(5, 4);
        Card a6h = new Card(6, 4);
        Card a7h = new Card(7, 4);
        Card a8h = new Card(8, 4);
        Card a9h = new Card(9, 4);
        Card a10h = new Card(10, 4);
        Card a11h = new Card(11, 4);
        Card a12h = new Card(12, 4);
        Card a13h = new Card(13, 4);

        //Diamonds
        Card a1d = new Card(1, 3);
        Card a2d = new Card(2, 3);
        Card a3d = new Card(3, 3);
        Card a4d = new Card(4, 3);
        Card a5d = new Card(5, 3);
        Card a6d = new Card(6, 3);
        Card a7d = new Card(7, 3);
        Card a8d = new Card(8, 3);
        Card a9d = new Card(9, 3);
        Card a10d = new Card(10, 3);
        Card a11d = new Card(11, 3);
        Card a12d = new Card(12, 3);
        Card a13d = new Card(13, 3);

        //Clubs
        Card a1c = new Card(1, 2);
        Card a2c = new Card(2, 2);
        Card a3c = new Card(3, 2);
        Card a4c = new Card(4, 2);
        Card a5c = new Card(5, 2);
        Card a6c = new Card(6, 2);
        Card a7c = new Card(7, 2);
        Card a8c = new Card(8, 2);
        Card a9c = new Card(9, 2);
        Card a10c = new Card(10, 2);
        Card a11c = new Card(11, 2);
        Card a12c = new Card(12, 2);
        Card a13c = new Card(13, 2);

        List<Card> newDeck = new List<Card>();
        List<Card> shuffledDeck = new List<Card>();

        public Deck()
        {
            //add the cards to the original deck
               newDeck.Add(a1s);
               newDeck.Add(a2s);
               newDeck.Add(a3s);
               newDeck.Add(a4s);
               newDeck.Add(a5s);
               newDeck.Add(a6s);
               newDeck.Add(a7s);
               newDeck.Add(a8s);
               newDeck.Add(a9s);
               newDeck.Add(a10s);
               newDeck.Add(a11s);
               newDeck.Add(a12s);
               newDeck.Add(a13s);
               newDeck.Add(a1h);
               newDeck.Add(a2h);
               newDeck.Add(a3h);
               newDeck.Add(a4h);
               newDeck.Add(a5h);
               newDeck.Add(a6h);
               newDeck.Add(a7h);
               newDeck.Add(a8h);
               newDeck.Add(a9h);
               newDeck.Add(a10h);
               newDeck.Add(a11h);
               newDeck.Add(a12h);
               newDeck.Add(a13h);
               newDeck.Add(a1d);
               newDeck.Add(a2d);
               newDeck.Add(a3d);
               newDeck.Add(a4d);
               newDeck.Add(a5d);
               newDeck.Add(a6d);
               newDeck.Add(a7d);
               newDeck.Add(a8d);
               newDeck.Add(a9d);
               newDeck.Add(a10d);
               newDeck.Add(a11d);
               newDeck.Add(a12d);
               newDeck.Add(a13d);
               newDeck.Add(a1c);
               newDeck.Add(a2c);
               newDeck.Add(a3c);
               newDeck.Add(a4c);
               newDeck.Add(a5c);
               newDeck.Add(a6c);
               newDeck.Add(a7c);
               newDeck.Add(a8c);
               newDeck.Add(a9c);
               newDeck.Add(a10c);
               newDeck.Add(a11c);
               newDeck.Add(a12c);
               newDeck.Add(a13c);
               Shuffle();
        }

        private void Shuffle()
        {
            //get a random number and and transfer that car to new array
            Random x = new Random();
            for (int i = 0; i < newDeck.Count(); i++)
            {
                int y = x.Next(0, newDeck.Count());
                Card nextCard = newDeck[y];

                //make sure the card is not already added
                IsInShuffledDeck = isInShuffledDeck(nextCard);

                if (IsInShuffledDeck == false)
                {
                    shuffledDeck.Add(nextCard);
                }
                else
                {
                    --i;
                }
            }
            
        }
        public Card GetNextCard()
        {
            //gets the first index of the array 
            //then removes the item from the array
            Card GetNextCard = shuffledDeck[0];
            shuffledDeck.Remove(GetNextCard);
            return GetNextCard;
            
        }
        internal int GetNumberOfCardsRemaining()
        {
            int cardsRemaining = shuffledDeck.Count();
            return cardsRemaining;
        }
        private bool isInShuffledDeck(Card unsorted)
        {
            foreach (Card item in shuffledDeck)
            {
                if (unsorted.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
