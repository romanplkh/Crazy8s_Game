using System;
using System.Windows.Forms;

namespace Crazy8s_Game
{
   public partial class Splash : Form
   {
      public Splash()
      {
         InitializeComponent();
      }

      private void splash_Load( object sender, EventArgs e )
      {
      }

      private void timer1_Tick( object sender, EventArgs e )
      {
         DialogResult = DialogResult.OK;
      }
   }
}