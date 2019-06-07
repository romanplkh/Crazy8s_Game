using Game_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crazy8s_Game
{
   public partial class App : Form
   {
      public App()
      {
         InitializeComponent();
      }

      private Game game;

      private void App_Load( object sender, EventArgs e )
      {
         Splash sp = new Splash();
         sp.ShowDialog();

         if ( sp.DialogResult == DialogResult.OK )
         {
            this.Show();
         }

         game = new Game();
         lblMessage.Text = "Click Deal to start the game.";
         btnPass.Visible = false;
      }

      private void btnStartGame_Click( object sender, EventArgs e )
      {
         game.Init();
         ShowHandComputer(panComputer, game.HandComputer);
         ShowHandTable(panTable, game.HandTable);
         ShowHandPlayer(panPlayer, game.HandPlayer);
         ShowDeck(panDeck);
         lblMessage.Text = "";
         btnPass.Visible = true;
      }

      public void ShowHandTable( Panel p, Hand hand )
      {
         try
         {
            p.Controls.Clear();
            Card card;
            PictureBox pic;

            card = hand[hand.CountCardsInHand - 1];
            string path = $@"images\{card.FaceValue}{card.Suit}.jpg";

            pic = new PictureBox()
            {
               Image = Image.FromFile(path),
               Text = card.FaceValue.ToString(),
               Width = 71,
               Height = 100,
               Tag = card
            };

            p.Controls.Add(pic);
         }
         catch ( Exception ex )
         {
            MessageBox.Show(ex.Message, "Error");
         }
      }

      public void ShowHandComputer( Panel p, Hand hand, string hidden = "hidden" )
      {
         try
         {
            p.Controls.Clear();
            Card card;
            PictureBox pic;

            for ( int i = 0; i < hand.CountCardsInHand; i++ )
            {
               card = hand[i];
               string path = "";

               if ( hidden.ToLower() == "hidden" )
               {
                  path = $@"images\cardback.gif";
               }
               else if ( hidden.ToLower() == "open" )
               {
                  path = $@"images\{card.FaceValue}{card.Suit}.jpg";
               }

               pic = new PictureBox()
               {
                  Image = Image.FromFile(path),
                  Width = 71,
                  Height = 100,
                  Left = 75 * i,
                  Tag = card
               };

               p.Controls.Add(pic);
            }
         }
         catch ( Exception ex )
         {
            MessageBox.Show(ex.Message, "Error");
         }
      }

      public void ShowHandPlayer( Panel p, Hand hand )
      {
         try
         {
            p.Controls.Clear();

            Card card;
            PictureBox pic;

            for ( int i = 0; i < hand.CountCardsInHand; i++ )
            {
               card = hand[i];

               string path = $@"images\{card.FaceValue}{card.Suit}.jpg";

               pic = new PictureBox()
               {
                  Image = Image.FromFile(path),
                  Text = card.FaceValue.ToString(),
                  Width = 71,
                  Height = 100,
                  Left = 75 * i,

                  Tag = card
               };

               pic.Click -= OnClickCard;
               pic.Click += OnClickCard;

               p.Controls.Add(pic);
            }

            if ( game.HandPlayer.ContainsWildCard() )
            {
               grpSuit.Visible = true;
            }
            else
            {
               grpSuit.Visible = false;
            }
         }
         catch ( Exception ex )
         {
            MessageBox.Show(ex.Message, "Error");
         }
      }

      public void ShowDeck( Panel p )
      {
         try
         {
            p.Controls.Clear();
            PictureBox pic;
            string path = $@"images\cardback.gif.";

            pic = new PictureBox()
            {
               Image = Image.FromFile(path),
               Width = 100,
               Height = 100,
            };

            pic.Click -= GetClickedCard;
            pic.Click += GetClickedCard;

            p.Controls.Add(pic);
         }
         catch ( Exception ex )
         {
            MessageBox.Show(ex.Message, "Error");
         }
      }

      public void GetClickedCard( object sender, EventArgs e )
      {
         if ( game.GameIsPlaying )
         {
            lblMessage.ResetText();
            game.AddCardUserClicked();

            ShowHandPlayer(panPlayer, game.HandPlayer);
            lblMessage.Text = game.Messages;
         }
      }

      private void OnClickCard( object sender, EventArgs e )
      {
         try
         {
            lblMessage.ResetText();

            //Default suit
            Suit selectedUserSuit = Suit.Hearts;

            foreach ( Control ctr in grpSuit.Controls )
            {
               if ( ctr is RadioButton )
               {
                  RadioButton rd = (RadioButton)ctr;

                  if ( rd.Checked )
                  {
                     selectedUserSuit = (Suit)Enum.Parse(typeof(Suit), rd.Tag.ToString());
                  }
               }
            }

            PictureBox selectedPic = (PictureBox)sender;
            Card selectedUserCard = (Card)selectedPic.Tag;

            game.PlayerPlay(selectedUserCard, selectedUserSuit);

            ShowHandTable(panTable, game.HandTable);
            ShowHandPlayer(panPlayer, game.HandPlayer);

            lblMessage.Text = game.Messages;

            if ( game.RevealComputer )
            {
               ShowHandComputer(panComputer, game.HandComputer, "open");
               return;
            }

            if ( !game.PlayerActive )
            {
               timer1.Enabled = true;
            }
         }
         catch ( Exception ex )
         {
            lblMessage.Text = ex.Message;
         }
      }

      private void timer1_Tick( object sender, EventArgs e )
      {
         if ( !game.PlayerActive )
         {
            lblMessage.Text = "";
            game.ComputerPlay();
            ShowHandComputer(panComputer, game.HandComputer);
            ShowHandTable(panTable, game.HandTable);
            timer1.Enabled = false;

            lblMessage.Text = game.Messages;
         }
      }

      private void btnPass_Click( object sender, EventArgs e )
      {
         if ( game.GameIsPlaying )
         {
            game.PassTurn();
            timer1.Enabled = true;
            lblMessage.Text = game.Messages;
         }
      }
   }
}