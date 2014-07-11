using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment4
{
    class Hand
    {
        string handName = "High Card";
        private Card One, Two, Three, Four, Five;
        List<int> unSortedRanking = new List<int>();
        List<Card> sortedHand = new List<Card>();
        bool IsFlush = false;
        bool IsRoyalFlush = false;
        bool IsStraight = false;
        bool IsFourOfAKind = false;
        bool IsThreeOfAKind = false;
        bool IsFullHouse = false;
        bool IsPair = false;
        bool IsTwoPair = false;
        bool IsInFInalArray = false;
        bool IsStraightFlush = false;

        public Hand(Card one, Card two, Card three, Card four, Card five)
        {
            One = one;
            Two = two;
            Three = three;
            Four = four;
            Five = five;
            Card[] input = { One, Two, Three, Four, Five };

            //add the cards to the hand list so that it can be Sorted
            List<Card> newHand = new List<Card>(input);

            //send the rank to the unsorted array
            foreach (Card cardRank in newHand)
            {
                GetSortedHand(cardRank);
            }

            //sort the unsorted rankings
            unSortedRanking.Sort();

            // now add Card values to a new array in the sam order as the sorted array.
            for (int j = 0; j < unSortedRanking.Count; j++)
            {
                int rank = unSortedRanking[j];

                for (int i = 0; i < newHand.Count; i++)
                {
                    Card unsorted = newHand[i];
                    IsInFInalArray = isInfinalArrayMethod(unsorted);
                    if (IsInFInalArray == false && unsorted.GetRank() == rank)
                    {
                        sortedHand.Add(unsorted);
                    }
                    ///Make this a nested for loop       
                }
            }

            //Send to the evaluation
            GetDisplayString(sortedHand);

        }
        //determine if the item is in the array to avoid adding it again. 
        private bool isInfinalArrayMethod(Card unsorted)
        {
            foreach (Card item in sortedHand)
            {
                if (unsorted.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        private void GetSortedHand(Card cardRank)
        {
            var loHi1 = cardRank.GetRank();
            unSortedRanking.Add(loHi1);

        }

        public void GetDisplayString(List<Card> newHand)
        {
            Console.Write("Your hand is: ");
           
            foreach (Card cardInstance in newHand)
            {
                Console.Write("{0}{1} ", cardInstance.RankText, cardInstance.GetSuite());
            }

            string result = GetPokerHandName(newHand);
            Console.WriteLine("");
            Console.WriteLine("Your have a {0}", result);
           
        }

        private string GetPokerHandName(List<Card> newHand)
        {

            // evaluate hand here. 
            IsRoyalFlush = isRoyalFlushMethod(newHand);
            IsFourOfAKind = isFourOfAKindMethod(newHand);
            IsStraightFlush = isStraightFlushMethod(newHand);
            IsFlush = isFlushMethod(newHand);
            IsStraight = isStraightMethod(newHand);
            IsThreeOfAKind = isThreeOfAKindMethod(newHand);
            IsFullHouse = isFullHouse(newHand);
            IsTwoPair = isTwoPair(newHand);
            IsPair = isPair(newHand);

            if (IsRoyalFlush == true)
            {
                handName = "Royal Flush";
            }
            if (IsStraight == true)
            {
                handName = "Straight";
            }
            if (IsFlush == true && IsRoyalFlush == false)
            {
                handName = "Flush";
            }
            if (IsStraightFlush == true)
            {
                handName = "Straight Flush";
            }
            if (IsFourOfAKind == true)
            {
                handName = "Four of a Kind";
            }
            if (IsFullHouse == true)
            {
                handName = "Full House";
            }
            if (IsThreeOfAKind == true)
            {
                handName = "Three of a Kind";
            }
            if (IsTwoPair == true)
            {
                handName = "Two Pair";
            }
            if (IsPair == true)
            {
                handName = "Pair";
            }
            return handName;
        }

        //evaluation methods
        private bool isPair(List<Card> newHand)
        {
            if ((newHand[0].GetRank() == newHand[1].GetRank()
            && newHand[1].GetRank() != newHand[2].GetRank()
            && newHand[2].GetRank() != newHand[3].GetRank()
            && newHand[3].GetRank() != newHand[4].GetRank())
            || (newHand[0].GetRank() != newHand[1].GetRank()
            && newHand[1].GetRank() == newHand[2].GetRank()
            && newHand[2].GetRank() != newHand[3].GetRank()
            && newHand[3].GetRank() != newHand[4].GetRank())
            || (newHand[0].GetRank() != newHand[1].GetRank()
            && newHand[1].GetRank() != newHand[2].GetRank()
            && newHand[2].GetRank() == newHand[3].GetRank()
            && newHand[3].GetRank() != newHand[4].GetRank())
            || (newHand[0].GetRank() != newHand[1].GetRank()
            && newHand[1].GetRank() != newHand[2].GetRank()
            && newHand[2].GetRank() != newHand[3].GetRank()
            && newHand[3].GetRank() == newHand[4].GetRank()))
            {
                IsPair = true;
            }
            else
            {
                IsPair = false;
            }
            return IsPair;
        }

        private bool isTwoPair(List<Card> newHand)
        {
            if ((newHand[0].GetRank() == newHand[1].GetRank()
           && newHand[1].GetRank() != newHand[2].GetRank()
           && newHand[2].GetRank() == newHand[3].GetRank()
           && newHand[3].GetRank() != newHand[4].GetRank())
           || (newHand[0].GetRank() != newHand[1].GetRank()
           && newHand[1].GetRank() == newHand[2].GetRank()
           && newHand[2].GetRank() != newHand[3].GetRank()
           && newHand[3].GetRank() == newHand[4].GetRank())
           || (newHand[0].GetRank() == newHand[1].GetRank()
           && newHand[1].GetRank() != newHand[2].GetRank()
           && newHand[2].GetRank() != newHand[3].GetRank()
           && newHand[3].GetRank() == newHand[4].GetRank()))
            {
                IsTwoPair = true;
            }
            else
            {
                IsTwoPair = false;
            }
            return IsTwoPair;
        }

        private bool isFullHouse(List<Card> newHand)
        {
            if ((newHand[0].GetRank() == newHand[1].GetRank()
            && newHand[1].GetRank() == newHand[2].GetRank()
            && newHand[2].GetRank() != newHand[3].GetRank()
            && newHand[3].GetRank() == newHand[4].GetRank())
            || (newHand[0].GetRank() == newHand[1].GetRank()
            && newHand[1].GetRank() != newHand[2].GetRank()
            && newHand[2].GetRank() == newHand[3].GetRank()
            && newHand[3].GetRank() == newHand[4].GetRank()))
            {
                IsFullHouse = true;
            }
            else
            {
                IsFullHouse = false;
            }
            return IsFullHouse;
        }

        private bool isThreeOfAKindMethod(List<Card> newHand)
        {
            if ((newHand[0].GetRank() == newHand[1].GetRank()
            && newHand[1].GetRank() == newHand[2].GetRank()
            && newHand[2].GetRank() != newHand[3].GetRank()
            && newHand[3].GetRank() != newHand[4].GetRank())
            || (newHand[0].GetRank() != newHand[1].GetRank()
            && newHand[1].GetRank() == newHand[2].GetRank()
            && newHand[2].GetRank() == newHand[3].GetRank()
            && newHand[3].GetRank() != newHand[4].GetRank())
            || (newHand[0].GetRank() != newHand[1].GetRank()
            && newHand[1].GetRank() != newHand[2].GetRank()
            && newHand[2].GetRank() == newHand[3].GetRank()
            && newHand[3].GetRank() == newHand[4].GetRank()))
            {
                IsThreeOfAKind = true;
            }
            else
            {
                IsThreeOfAKind = false;
            }
            return IsThreeOfAKind;
        }

        private bool isFourOfAKindMethod(List<Card> newHand)
        {
            if ((newHand[0].GetRank() == newHand[1].GetRank()
             && newHand[1].GetRank() == newHand[2].GetRank()
             && newHand[2].GetRank() == newHand[3].GetRank())
             || (newHand[1].GetRank() == newHand[2].GetRank()
             && newHand[2].GetRank() == newHand[3].GetRank()
             && newHand[3].GetRank() == newHand[4].GetRank())
             || (newHand[0].GetRank() == newHand[2].GetRank()
             && newHand[2].GetRank() == newHand[3].GetRank()
             && newHand[3].GetRank() == newHand[4].GetRank())
             || (newHand[0].GetRank() == newHand[1].GetRank()
             && newHand[2].GetRank() == newHand[3].GetRank()
             && newHand[3].GetRank() == newHand[4].GetRank()
             || (newHand[0].GetRank() == newHand[1].GetRank()
             && newHand[1].GetRank() == newHand[2].GetRank()
             && newHand[3].GetRank() == newHand[4].GetRank()))
              )
            {
                IsFourOfAKind = true;
            }
            else
            {
                IsFourOfAKind = false;
            }
            return IsFourOfAKind;
        }

        private bool isRoyalFlushMethod(List<Card> newHand)
        {
            if (newHand[0].GetSuite() == newHand[1].GetSuite()
               && newHand[1].GetSuite() == newHand[2].GetSuite()
               && newHand[2].GetSuite() == newHand[3].GetSuite()
               && newHand[3].GetSuite() == newHand[4].GetSuite()
               && (newHand[0].GetRank() == 1 && newHand[1].GetRank() == 10
               && newHand[2].GetRank() == 11 && newHand[3].GetRank() == 12
               && newHand[4].GetRank() == 13))
            {
                IsRoyalFlush = true;
            }
            else
            {
                IsRoyalFlush = false;
            }
            return IsRoyalFlush;
        }

        private bool isStraightFlushMethod(List<Card> newHand)
        {
            if ((newHand[1].GetRank() == newHand[0].GetRank() + 1
               && newHand[2].GetRank() == newHand[1].GetRank() + 1
               && newHand[3].GetRank() == newHand[2].GetRank() + 1
               && newHand[4].GetRank() == newHand[3].GetRank() + 1)
               || (newHand[0].GetRank() == 1 && newHand[1].GetRank() == 10
               && newHand[2].GetRank() == 11 && newHand[3].GetRank() == 12
               && newHand[4].GetRank() == 13)
                && (newHand[0].GetSuite() == newHand[1].GetSuite()
                && newHand[1].GetSuite() == newHand[2].GetSuite()
                && newHand[2].GetSuite() == newHand[3].GetSuite()
                && newHand[3].GetSuite() == newHand[4].GetSuite()))
            {
                IsStraightFlush = true;
            }
            else
            {
                IsStraightFlush = false;
            }
            return IsStraightFlush;
        }

        private bool isStraightMethod(List<Card> newHand)
        {
            if (newHand[1].GetRank() == newHand[0].GetRank() + 1
               && newHand[2].GetRank() == newHand[1].GetRank() + 1
               && newHand[3].GetRank() == newHand[2].GetRank() + 1
               && newHand[4].GetRank() == newHand[3].GetRank() + 1
               || (newHand[0].GetRank() == 1 && newHand[1].GetRank() == 10
               && newHand[2].GetRank() == 11 && newHand[3].GetRank() == 12
               && newHand[4].GetRank() == 13))
            {
                IsStraight = true;
            }
            else
            {
                IsStraight = false;
            }
            return IsStraight;
        }

        private bool isFlushMethod(List<Card> newHand)
        {
            if (newHand[0].GetSuite() == newHand[1].GetSuite()
                && newHand[1].GetSuite() == newHand[2].GetSuite()
                && newHand[2].GetSuite() == newHand[3].GetSuite()
                && newHand[3].GetSuite() == newHand[4].GetSuite())
            {
                IsFlush = true;
            }
            else
            {
                IsFlush = false;
            }
            return IsFlush;
        }

    }
}
