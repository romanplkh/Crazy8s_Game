using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Classes
{
   public class Hand
   {
      private List<Card> _cardsInHand = new List<Card>();

      public Card this[int index]
      {
         get
         {
            return this._cardsInHand[index];
         }
      }

      public int CountCardsInHand
      {
         get
         {
            return this._cardsInHand.Count;
         }
      }

      public int GetCardIndex( Card card )
      {
         return this._cardsInHand.IndexOf(card);
      }

      public void AddCard( Card card )
      {
         this._cardsInHand.Add(card);
      }

      private bool ContainsCard( Card cardToCheck )
      {
         foreach ( Card card in this._cardsInHand )
         {
            if ( card.FaceValue == cardToCheck.FaceValue && card.Suit == cardToCheck.Suit )
            {
               return true;
            }
         }

         return false;
      }

      public void RemoveCard( Card theCard )
      {
         if ( this._cardsInHand.Contains(theCard) )
         {
            this._cardsInHand.Remove(theCard);
         }
         else
         {
            throw new ConstraintException($"{theCard.FaceValue} of {theCard.Suit} already exists in the hand");
         }
      }

      public void RemoveCard( int index )
      {
         if ( index <= this._cardsInHand.Count - 1 )
         {
            this._cardsInHand.RemoveAt(index);
         }
         else
         {
            throw new DataException("Index value exceeds the number of cards in the hand");
         }
      }

      public void RemoveCard( Suit theSuit, FaceValue theFaceValue )
      {
         foreach ( Card card in this._cardsInHand )
         {
            if ( card.Suit == theSuit && card.FaceValue == theFaceValue )
            {
               this._cardsInHand.Remove(card);
               return;
            }
         }
      }

      public bool ContainsWildCard()
      {
         int numWildCards = 0;
         foreach ( Card c in this._cardsInHand )
         {
            if ( c.FaceValue == FaceValue.Eight )
            {
               numWildCards++;
            }
         }

         if ( numWildCards > 0 )
         {
            return true;
         }

         return false;
      }
   }
}