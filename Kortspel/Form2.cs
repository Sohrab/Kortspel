using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kortspel
{
    public partial class Form2 : Form
    {
        int playerScore = 0;
        int compScore = 0; //Player 2 score
        int playerEss = 0;
        int playerTwoEss = 0;

        Kortbunt lek = new Kortbunt();

        public Form2()
        {
            InitializeComponent();




            //Släcker oanvändbara knappar innan start
            button1.Enabled = false;
            btnStop.Enabled = false;
            button2.Enabled = false;
            btnStop2.Enabled = false;






        }

        private void card_Click(object sender, EventArgs e)
        {
            Kort k = (Kort)sender;
            //k.Synligt = !k.Synligt;

            lblMarkedCard.Text = k.Värde.ToString();

        }



        //Spelare 1's knappar
        private void button1_Click_1(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            


            if (playerScore < 21)
            {
                Kort k = lek.TaBortÖversta();
                flowLayoutPanel1.Controls.Add(k);
                k.Click += card_Click;
                this.playerScore = playerScore + k.Värde;
                lblPlayerScore.Text = playerScore.ToString();

                  //Checkar och lagrar Ess
                KortValör v = k.Valör;

                if (v == KortValör.ESS)
                {
                    playerEss++;
                }


            
            /*if (playerScore > 21 && playerEss > 0)
            {
                for (int i = 0; i < playerEss; i++)
                {
                    playerScore -= 13;
                }
            }*/

            }
            if (playerScore > 21)
            {
                lblWinner.Location = new Point(395, 145);
                lblWinner.Text = "Vinnare: Spelare 2";
                button1.Enabled = false;
                btnStop.Enabled = false;
                btnNewGame.Enabled = true;

            }
            if (playerScore == 21)
            {

                button1.Enabled = false;
                btnStop.Enabled = false;


                //Sätter igång spelare 2's knappar
                button2.Enabled = true;
                btnStop2.Enabled = true;

            }

        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnStop.Enabled = false;


            //Sätter igång spelare 2's knappar
            button2.Enabled = true;
            btnStop2.Enabled = true;

        }







        //Spelare 2's knappar

        private void button2_Click(object sender, EventArgs e)
        {
            if (compScore < 21)
            {
                Kort k = lek.TaBortÖversta();
                flowLayoutPanel2.Controls.Add(k);
                k.Click += card_Click;
                this.compScore = compScore + k.Värde;
                lblComputerScore.Text = compScore.ToString();


            }
            if (compScore > 21)
            {
                lblWinner.Location = new Point(395, 145);
                lblWinner.Text = "Vinnare: Spelare 1";
                button2.Enabled = false;
                btnStop2.Enabled = false;
                btnNewGame.Enabled = true;

            }
            if (compScore == 21)
            {
                if (playerScore == 21)
                {
                    lblWinner.Location = new Point(435, 145);
                    lblWinner.Text = "Oavgjort!";
                    button2.Enabled = false;
                    btnStop2.Enabled = false;
                    btnNewGame.Enabled = true;
                }
                else
                {
                    lblWinner.Location = new Point(395, 145);
                    lblWinner.Text = "Vinnare: Spelare 2";
                    button2.Enabled = false;
                    btnStop2.Enabled = false;
                    btnNewGame.Enabled = true;
                }

            }



        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            if (playerScore > compScore)
            {
                lblWinner.Location = new Point(395, 145);
                lblWinner.Text = "Vinnare: Spelare 1";
                button2.Enabled = false;
                btnStop2.Enabled = false;
                btnNewGame.Enabled = true;

            }
            else if (playerScore == compScore)
            {
                lblWinner.Location = new Point(435, 145);
                lblWinner.Text = "Oavgjort!";
                button2.Enabled = false;
                btnStop2.Enabled = false;
                btnNewGame.Enabled = true;
            }
            else
            {
                lblWinner.Location = new Point(395, 145);
                lblWinner.Text = "Vinnare: Spelare 2";
                button2.Enabled = false;
                btnStop2.Enabled = false;
                btnNewGame.Enabled = true;
            }
        }







        //Spela knappen

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            //Nollställer spelet


            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            this.lek = new Kortbunt();
            this.lek.NyKortlek();
            this.lek.Blanda();
            this.playerScore = 0;
            this.compScore = 0;
            button1.Enabled = true;
            lblComputerScore.Text = "0";
            lblPlayerScore.Text = "0";
            lblWinner.Text = "";
            btnNewGame.Enabled = false;
        }





    }










}
