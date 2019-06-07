using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Classes
{
   public class Card
   {
      /// <summary>
      /// GET THE SUIT FOR THE CARD
      /// </summary>
      public Suit Suit { get; set; }

      /// <summary>
      /// GET THE FACE FALUE OF THE CARD
      /// </summary>
      public FaceValue FaceValue { get; set; }

      /// <summary>
      ///// CONSTRUCTS A CARD BY PASSING THE FACEVALUE AND SUIT
      /// </summary>
      /// <param name="newSuit"></param>
      /// <param name="newValue"></param>

      public Card( Suit newSuit, FaceValue newValue )
      {
         this.Suit = newSuit;
         this.FaceValue = newValue;
      }
   }
}