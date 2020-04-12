using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Hand
    {
        private List<Card> cards = new List<Card>();

        public int Count
        {
            get
            {
                return cards.Count();
            }
        }


        public Card this[int index]
        {
            get
            {
                return cards[index];
            }
        }

        public void AddCard(Card newCard)
        {
            if (ContainsCard(newCard))
            {
                throw new ConstraintException(newCard.FaceValue.ToString() + " of " +
                    newCard.Suit.ToString() + " already exists in the Handsss");
            }

            cards.Add(newCard);
        }


        private bool ContainsCard(Card cardToCheck)
        {
            return cards.Where(card => card.FaceValue == cardToCheck.FaceValue && card.Suit == cardToCheck.Suit).Count() != 0;
        }

        public void RemoveCard(Card theCard)
        {
            if (!cards.Contains(theCard))
            {
                throw new ConstraintException(theCard.FaceValue.ToString() + " of " +
                    theCard.Suit.ToString() + " does not exist in the hand.");
            }

            cards.Remove(theCard);
        }

        /// <summary>
        /// Shuffle cards in hand so that the player can't predict the position of the card
        /// </summary>
        public void Shuffle()
        {
            List<Card> newHand = new List<Card>();
            Random rGen = new Random();

            while (cards.Count > 0)
            {
                int removeIndex = rGen.Next(0, cards.Count);
                Card cardToRemove = cards[removeIndex];
                cards.RemoveAt(removeIndex);
                newHand.Add(cardToRemove);
            }

            // replace the old deck with the next deck
            cards = newHand;
        }

        /// <summary>
        /// find same facevalue of cards when users pick card or start
        /// </summary>
        /// <param name="theFaceValue"></param>
        /// <returns></returns>
        public List<Card> sortHand(FaceValue theFaceValue)
        {
            return cards.Where(c => c.FaceValue == theFaceValue).ToList();
        }
    }
}
