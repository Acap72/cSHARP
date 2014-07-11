using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment4
{
    class Dealer : Deck
    {
        Card One;
        Card Two;
        Card Three;
        Card Four;
        Card Five;

        internal Hand DealHand()
        {
            Card One = GetNextCard();
            Card Two = GetNextCard();
            Card Three = GetNextCard();
            Card Four = GetNextCard();
            Card Five = GetNextCard();

            Hand nextHand = new Hand(One, Two, Three, Four, Five);
            return nextHand;
        }
    }
}
