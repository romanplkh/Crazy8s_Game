using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Classes
{
   public class Game
   {
      public bool GameIsPlaying { get; set; }
      public bool PlayerActive { get; private set; }
      public bool RevealComputer { get; private set; }
      public Hand HandPlayer { get; private set; }

      public Hand HandComputer { get; private set; }

      public Hand HandTable { get; private set; }

      private Deck Deck { get; set; }

      public string Messages { get; private set; }

      public void Init()
      {
         Deck = new Deck();
         Deck.Shuffle();

         HandPlayer = Deck.DealHand(8);
         HandComputer = Deck.DealHand(8);
         HandTable = Deck.DealHand(1);
         GameIsPlaying = true;
         PlayerActive = true;
      }

      public void IsWinner()
      {
         if ( HandComputer.CountCardsInHand == 0 )
         {
            GameIsPlaying = false;
            Messages = $"Computer WON!!! But you were close. Try again.";
         }
         else if ( HandPlayer.CountCardsInHand == 0 )
         {
            GameIsPlaying = false;
            Messages = $"You WON!!! Congratulations!!!";
            RevealComputer = true;
         }
      }

      public void AddCardUserClicked()
      {
         ResetMessage();
         if ( Deck.DeckCount > 0 && GameIsPlaying )
         {
            if ( HandPlayer.CountCardsInHand <= 11 )
            {
               Card card = Deck.DrawOneCard();
               HandPlayer.AddCard(card);
            }
            else
            {
               Messages = "You cannot have more than 12 cards. \n You should play or pass your turn";
               return;
            }
         }
         else
         {
            if ( GameIsPlaying )
            {
               RedealFromPile();
            }
         }
      }

      public void PassTurn()
      {
         if ( HandPlayer.CountCardsInHand != 12 )
         {
            Messages = "You cannot pas turn if your hand is not full. \n Take a card!";
         }
         else
         {
            PlayerActive = false;
         }
      }

      private void RedealFromPile()
      {
         Deck.ReuseDeckFromTablePile(HandTable);
         Deck.Shuffle();

         for ( int i = 0; i < HandTable.CountCardsInHand - 1; i++ )
         {
            HandTable.RemoveCard(i);
         }
      }

      public void PlayerPlay( Card c, Suit selectedUserSuit )
      {
         if ( GameIsPlaying )
         {
            ResetMessage();
            Card topCardOnTable = HandTable[HandTable.CountCardsInHand - 1];
            Card selectedUserCard = c;

            if ( IsRegularCard(selectedUserCard, topCardOnTable) )
            {
               HandTable.AddCard(c);
               HandPlayer.RemoveCard(c);
               PlayerActive = false;
               IsWinner();
            }
            else if ( IsWildCard(selectedUserCard) )
            {
               selectedUserCard.Suit = selectedUserSuit;
               HandTable.AddCard(selectedUserCard);
               HandPlayer.RemoveCard(HandPlayer.GetCardIndex(selectedUserCard));
               PlayerActive = false;
               IsWinner();
            }
            else
            {
               Messages = $"You cannot play the {selectedUserCard.FaceValue} of {selectedUserCard.Suit} now";
               PlayerActive = true;
            }
         }
      }

      public void ComputerPlay()
      {
         if ( !PlayerActive && GameIsPlaying )
         {
            ResetMessage();
            Card topCardOnTable = HandTable[HandTable.CountCardsInHand - 1];

            Card c;

            for ( int i = 0; i < HandComputer.CountCardsInHand; i++ )
            {
               c = HandComputer[i];

               if ( IsRegularCard(c, topCardOnTable) )
               {
                  HandTable.AddCard(c);
                  HandComputer.RemoveCard(c);
                  IsWinner();
                  PlayerActive = true;
                  return;
               }
            }

            for ( int i = 0; i < HandComputer.CountCardsInHand; i++ )
            {
               c = HandComputer[i];

               if ( IsWildCard(c) )
               {
                  int cardIndex = HandComputer.GetCardIndex(HandComputer[i]);

                  Random rnd = new Random();

                  Suit suit = (Suit)rnd.Next(0, Enum.GetValues(typeof(Suit)).Length);
                  c.Suit = suit;

                  HandTable.AddCard(c);
                  HandComputer.RemoveCard(cardIndex);
                  IsWinner();
                  PlayerActive = true;
                  return;
               }
            }

            //IF NO CARD MATCHES TAKE A CARD
            if ( Deck.DeckCount > 0 )
            {
               if ( HandComputer.CountCardsInHand <= 11 )
               {
                  Card topCard = Deck.DrawOneCard();
                  HandComputer.AddCard(topCard);
                  //Recursion => Repeat all code above when draw new card
                  ComputerPlay();
                  IsWinner();
               }
               else
               {
                  PlayerActive = true;
                  Messages = "Computer does not have any matching card. \n Your turn";
               }
            }
            else
            {
               RedealFromPile();
               ComputerPlay();
            }
         }
      }

      private bool IsRegularCard( Card selected, Card tableTop )
      {
         if ( ( selected.Suit == tableTop.Suit || selected.FaceValue == tableTop.FaceValue ) && selected.FaceValue != FaceValue.Eight )
         {
            return true;
         }
         return false;
      }

      private bool IsWildCard( Card selected )
      {
         if ( selected.FaceValue == FaceValue.Eight )
         {
            return true;
         }
         return false;
      }

      private void ResetMessage()
      {
         Messages = "";
      }
   }
}