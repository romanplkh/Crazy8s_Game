using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Classes
{
   public class Deck
   {
      //Collection of all cards
      private List<Card> _deck = new List<Card>();

      public Deck()
      {
         MakeDeck();
      }

      private void MakeDeck()
      {
         //Create 4 suits
         for ( int i = 0; i <= 3; i++ )
         {
            //Create 13 faces
            for ( int l = 0; l <= 12; l++ )
            {
               Card newCard = new Card((Suit)i, (FaceValue)l);
               _deck.Add(newCard);
            }
         }
      }

      public int DeckCount
      {
         get
         {
            return this._deck.Count;
         }
      }

      public void ReuseDeckFromTablePile( Hand tableHand )
      {
         //One card left on table
         for ( int i = 0; i < tableHand.CountCardsInHand - 1; i++ )
         {
            this._deck.Add(tableHand[i]);
         }
      }

      public void Shuffle()
      {
         Random rnd = new Random();
         List<Card> newDeck = new List<Card>();

         while ( _deck.Count > 0 )
         {
            int removedIndex = rnd.Next(0, _deck.Count);

            Card removedObject = _deck[removedIndex];

            _deck.RemoveAt(removedIndex);

            newDeck.Add(removedObject);
         }

         _deck = newDeck;
      }

      public Card DrawOneCard()
      {
         Card topCard;

         if ( this._deck.Count > 0 )
         {
            topCard = this._deck[0];
            this._deck.RemoveAt(0);
         }
         else
         {
            throw new ArgumentException("There is no cards left in the deck");
         }

         return topCard;
      }

      //Number of cards we deal to user
      public Hand DealHand( int num )
      {
         if ( this._deck.Count == 0 )
         {
            throw new ConstraintException("There are no casds in deck.Redeal");
         }

         Hand hand = new Hand();

         //IF in deck we have enough cards we give cards to user and remove from deck
         if ( this._deck.Count >= num )
         {
            for ( int i = 0; i < num; i++ )
            {
               //Add card to hand
               hand.AddCard(this._deck[0]);
               //Remove card from Deck
               this._deck.RemoveAt(0);
            }
         }
         else
         {
            //DEAL WHAT IS LEFT

            int count = this._deck.Count;
            //If we have only 3 cards we need to pass them to user
            for ( int i = 0; i < count; i++ )
            {
               hand.AddCard(this._deck[0]);
               this._deck.RemoveAt(0);
            }
         }

         return hand;
      }
   }
}