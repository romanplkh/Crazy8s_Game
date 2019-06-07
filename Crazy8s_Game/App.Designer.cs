namespace Crazy8s_Game
{
   partial class App
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.panDeck = new System.Windows.Forms.Panel();
         this.panTable = new System.Windows.Forms.Panel();
         this.lblMessage = new System.Windows.Forms.Label();
         this.grpSuit = new System.Windows.Forms.GroupBox();
         this.rdoHearts = new System.Windows.Forms.RadioButton();
         this.rdoDiamonds = new System.Windows.Forms.RadioButton();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.rdoSpades = new System.Windows.Forms.RadioButton();
         this.rdoClubs = new System.Windows.Forms.RadioButton();
         this.pictureBox4 = new System.Windows.Forms.PictureBox();
         this.pictureBox3 = new System.Windows.Forms.PictureBox();
         this.pictureBox2 = new System.Windows.Forms.PictureBox();
         this.timer1 = new System.Windows.Forms.Timer(this.components);
         this.btnPass = new System.Windows.Forms.Button();
         this.panComputer = new System.Windows.Forms.FlowLayoutPanel();
         this.panPlayer = new System.Windows.Forms.FlowLayoutPanel();
         this.btnStartGame = new System.Windows.Forms.Button();
         this.pictureBox7 = new System.Windows.Forms.PictureBox();
         this.pictureBox5 = new System.Windows.Forms.PictureBox();
         this.pictureBox6 = new System.Windows.Forms.PictureBox();
         this.grpSuit.SuspendLayout();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox1 ) ).BeginInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox4 ) ).BeginInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox3 ) ).BeginInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox2 ) ).BeginInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox7 ) ).BeginInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox5 ) ).BeginInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox6 ) ).BeginInit();
         this.SuspendLayout();
         // 
         // panDeck
         // 
         this.panDeck.AutoSize = true;
         this.panDeck.Cursor = System.Windows.Forms.Cursors.Hand;
         this.panDeck.Location = new System.Drawing.Point(296, 260);
         this.panDeck.Name = "panDeck";
         this.panDeck.Size = new System.Drawing.Size(98, 93);
         this.panDeck.TabIndex = 2;
         // 
         // panTable
         // 
         this.panTable.Location = new System.Drawing.Point(502, 260);
         this.panTable.Name = "panTable";
         this.panTable.Size = new System.Drawing.Size(101, 93);
         this.panTable.TabIndex = 3;
         // 
         // lblMessage
         // 
         this.lblMessage.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
            | System.Windows.Forms.AnchorStyles.Left )
            | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.lblMessage.BackColor = System.Drawing.Color.Khaki;
         this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
         this.lblMessage.ForeColor = System.Drawing.Color.Black;
         this.lblMessage.Location = new System.Drawing.Point(156, 380);
         this.lblMessage.Name = "lblMessage";
         this.lblMessage.Size = new System.Drawing.Size(620, 50);
         this.lblMessage.TabIndex = 5;
         this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // grpSuit
         // 
         this.grpSuit.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.grpSuit.Controls.Add(this.rdoHearts);
         this.grpSuit.Controls.Add(this.rdoDiamonds);
         this.grpSuit.Controls.Add(this.pictureBox1);
         this.grpSuit.Controls.Add(this.rdoSpades);
         this.grpSuit.Controls.Add(this.rdoClubs);
         this.grpSuit.Controls.Add(this.pictureBox4);
         this.grpSuit.Controls.Add(this.pictureBox3);
         this.grpSuit.Controls.Add(this.pictureBox2);
         this.grpSuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ( (System.Drawing.FontStyle)( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic ) ) ), System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
         this.grpSuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         this.grpSuit.Location = new System.Drawing.Point(34, 235);
         this.grpSuit.Name = "grpSuit";
         this.grpSuit.Size = new System.Drawing.Size(115, 126);
         this.grpSuit.TabIndex = 6;
         this.grpSuit.TabStop = false;
         this.grpSuit.Text = "Select suit";
         // 
         // rdoHearts
         // 
         this.rdoHearts.AutoSize = true;
         this.rdoHearts.BackColor = System.Drawing.Color.White;
         this.rdoHearts.Checked = true;
         this.rdoHearts.Location = new System.Drawing.Point(18, 48);
         this.rdoHearts.Name = "rdoHearts";
         this.rdoHearts.Size = new System.Drawing.Size(14, 13);
         this.rdoHearts.TabIndex = 7;
         this.rdoHearts.TabStop = true;
         this.rdoHearts.Tag = "Hearts";
         this.rdoHearts.UseVisualStyleBackColor = false;
         // 
         // rdoDiamonds
         // 
         this.rdoDiamonds.AutoSize = true;
         this.rdoDiamonds.BackColor = System.Drawing.Color.White;
         this.rdoDiamonds.Location = new System.Drawing.Point(62, 95);
         this.rdoDiamonds.Name = "rdoDiamonds";
         this.rdoDiamonds.Size = new System.Drawing.Size(14, 13);
         this.rdoDiamonds.TabIndex = 10;
         this.rdoDiamonds.Tag = "Diamonds";
         this.rdoDiamonds.UseVisualStyleBackColor = false;

         // pictureBox1
         // 
         this.pictureBox1.Image = global::Crazy8s_Game.Properties.Resources.heart;
         this.pictureBox1.Location = new System.Drawing.Point(17, 21);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(38, 41);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 11;
         this.pictureBox1.TabStop = false;
         // 
         // rdoSpades
         // 
         this.rdoSpades.AutoSize = true;
         this.rdoSpades.BackColor = System.Drawing.Color.White;
         this.rdoSpades.Location = new System.Drawing.Point(18, 95);
         this.rdoSpades.Name = "rdoSpades";
         this.rdoSpades.Size = new System.Drawing.Size(14, 13);
         this.rdoSpades.TabIndex = 9;
         this.rdoSpades.Tag = "Spades";
         this.rdoSpades.UseVisualStyleBackColor = false;
         // 
         // rdoClubs
         // 
         this.rdoClubs.AutoSize = true;
         this.rdoClubs.BackColor = System.Drawing.Color.White;
         this.rdoClubs.Location = new System.Drawing.Point(62, 48);
         this.rdoClubs.Name = "rdoClubs";
         this.rdoClubs.Size = new System.Drawing.Size(14, 13);
         this.rdoClubs.TabIndex = 8;
         this.rdoClubs.Tag = "Clubs";
         this.rdoClubs.UseVisualStyleBackColor = false;
         // 
         // pictureBox4
         // 
         this.pictureBox4.Image = global::Crazy8s_Game.Properties.Resources.diamond;
         this.pictureBox4.Location = new System.Drawing.Point(61, 68);
         this.pictureBox4.Name = "pictureBox4";
         this.pictureBox4.Size = new System.Drawing.Size(38, 41);
         this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox4.TabIndex = 14;
         this.pictureBox4.TabStop = false;
         // 
         // pictureBox3
         // 
         this.pictureBox3.Image = global::Crazy8s_Game.Properties.Resources.spade;
         this.pictureBox3.Location = new System.Drawing.Point(17, 68);
         this.pictureBox3.Name = "pictureBox3";
         this.pictureBox3.Size = new System.Drawing.Size(38, 41);
         this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox3.TabIndex = 13;
         this.pictureBox3.TabStop = false;
         // 
         // pictureBox2
         // 
         this.pictureBox2.Image = global::Crazy8s_Game.Properties.Resources.club;
         this.pictureBox2.Location = new System.Drawing.Point(61, 21);
         this.pictureBox2.Name = "pictureBox2";
         this.pictureBox2.Size = new System.Drawing.Size(38, 41);
         this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox2.TabIndex = 12;
         this.pictureBox2.TabStop = false;
         // 
         // timer1
         // 
         this.timer1.Interval = 1400;
         this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
         // 
         // btnPass
         // 
         this.btnPass.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.btnPass.BackColor = System.Drawing.Color.GreenYellow;
         this.btnPass.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
         this.btnPass.Location = new System.Drawing.Point(818, 442);
         this.btnPass.Name = "btnPass";
         this.btnPass.Size = new System.Drawing.Size(117, 39);
         this.btnPass.TabIndex = 7;
         this.btnPass.Text = "Pass";
         this.btnPass.UseVisualStyleBackColor = false;
         this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
         // 
         // panComputer
         // 
         this.panComputer.Location = new System.Drawing.Point(156, 15);
         this.panComputer.Name = "panComputer";
         this.panComputer.Size = new System.Drawing.Size(620, 212);
         this.panComputer.TabIndex = 8;
         this.panComputer.Tag = "heart";
         // 
         // panPlayer
         // 
         this.panPlayer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.panPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
         this.panPlayer.Location = new System.Drawing.Point(156, 442);
         this.panPlayer.Name = "panPlayer";
         this.panPlayer.Size = new System.Drawing.Size(620, 211);
         this.panPlayer.TabIndex = 9;
         // 
         // btnStartGame
         // 
         this.btnStartGame.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.btnStartGame.BackColor = System.Drawing.Color.White;
         this.btnStartGame.Cursor = System.Windows.Forms.Cursors.AppStarting;
         this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
         this.btnStartGame.Location = new System.Drawing.Point(818, 188);
         this.btnStartGame.Name = "btnStartGame";
         this.btnStartGame.Size = new System.Drawing.Size(125, 38);
         this.btnStartGame.TabIndex = 4;
         this.btnStartGame.Text = "Deal";
         this.btnStartGame.UseVisualStyleBackColor = false;
         this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
         // 
         // pictureBox7
         // 
         this.pictureBox7.Image = global::Crazy8s_Game.Properties.Resources.lef_logo;
         this.pictureBox7.Location = new System.Drawing.Point(34, 15);
         this.pictureBox7.Name = "pictureBox7";
         this.pictureBox7.Size = new System.Drawing.Size(107, 113);
         this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox7.TabIndex = 12;
         this.pictureBox7.TabStop = false;
         // 
         // pictureBox5
         // 
         this.pictureBox5.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.pictureBox5.Image = global::Crazy8s_Game.Properties.Resources.logo_corner;
         this.pictureBox5.Location = new System.Drawing.Point(818, 67);
         this.pictureBox5.Name = "pictureBox5";
         this.pictureBox5.Size = new System.Drawing.Size(117, 97);
         this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox5.TabIndex = 10;
         this.pictureBox5.TabStop = false;
         // 
         // pictureBox6
         // 
         this.pictureBox6.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
         this.pictureBox6.Image = global::Crazy8s_Game.Properties.Resources.title;
         this.pictureBox6.Location = new System.Drawing.Point(790, -44);
         this.pictureBox6.Name = "pictureBox6";
         this.pictureBox6.Size = new System.Drawing.Size(181, 176);
         this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox6.TabIndex = 11;
         this.pictureBox6.TabStop = false;
         // 
         // App
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.BackColor = System.Drawing.Color.DarkGreen;
         this.ClientSize = new System.Drawing.Size(973, 664);
         this.Controls.Add(this.pictureBox7);
         this.Controls.Add(this.pictureBox5);
         this.Controls.Add(this.panPlayer);
         this.Controls.Add(this.panComputer);
         this.Controls.Add(this.btnPass);
         this.Controls.Add(this.grpSuit);
         this.Controls.Add(this.lblMessage);
         this.Controls.Add(this.btnStartGame);
         this.Controls.Add(this.panTable);
         this.Controls.Add(this.panDeck);
         this.Controls.Add(this.pictureBox6);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "App";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Crazy 8s";
         this.Load += new System.EventHandler(this.App_Load);
         this.grpSuit.ResumeLayout(false);
         this.grpSuit.PerformLayout();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox1 ) ).EndInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox4 ) ).EndInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox3 ) ).EndInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox2 ) ).EndInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox7 ) ).EndInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox5 ) ).EndInit();
         ( (System.ComponentModel.ISupportInitialize)( this.pictureBox6 ) ).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panDeck;
      private System.Windows.Forms.Panel panTable;
      private System.Windows.Forms.Button btnStartGame;
      private System.Windows.Forms.Label lblMessage;
      private System.Windows.Forms.GroupBox grpSuit;
      private System.Windows.Forms.RadioButton rdoDiamonds;
      private System.Windows.Forms.RadioButton rdoHearts;
      private System.Windows.Forms.RadioButton rdoSpades;
      private System.Windows.Forms.RadioButton rdoClubs;
      private System.Windows.Forms.Timer timer1;
      private System.Windows.Forms.Button btnPass;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.PictureBox pictureBox4;
      private System.Windows.Forms.PictureBox pictureBox3;
      private System.Windows.Forms.PictureBox pictureBox2;
      private System.Windows.Forms.FlowLayoutPanel panComputer;
      private System.Windows.Forms.FlowLayoutPanel panPlayer;
      private System.Windows.Forms.PictureBox pictureBox5;
      private System.Windows.Forms.PictureBox pictureBox6;
      private System.Windows.Forms.PictureBox pictureBox7;
   }
}

