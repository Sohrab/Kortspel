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
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int compScore = 0;
        Kortbunt lek = new Kortbunt();




        //Esses
        int playerEss = 0;
        int compEss = 0;



       // Player player = new Player(lek);
       // Computer comp = new Computer(lek, player);

        public Form1()
        {
            InitializeComponent();



            //Släcker oanvändbara knappar innan start
            button1.Enabled = false;
            btnStop.Enabled = false;





            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;



            if (playerScore <= 21)
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


            }


            /*5
            if (playerScore > 21 && playerEss > 0)
            {
                for (int i = 0; i < playerEss; i++)
                {
                    playerScore -= 13;
                }
            }*/


            if (playerScore > 21)
            {
                lblLooser.Text = "Du förlorade";
                button1.Enabled = false;
                btnStop.Enabled = false;
                btnNewGame.Enabled = true;
                
            }
            if (playerScore == 21)
            {
                lblWinner.Text = "Du vann!";
                button1.Enabled = false;
                btnStop.Enabled = false;
                btnNewGame.Enabled = true;
                
            }

            
            




        }

        private void card_Click(object sender, EventArgs e)
        {
            Kort k = (Kort)sender;
            //k.Synligt = !k.Synligt;

            lblMarkedCard.Text = k.Värde.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
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
            lblLooser.Text = "";
            btnNewGame.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {


            while (compScore < 21 && compScore < playerScore)
            {
                Kort k = lek.TaBortÖversta();
                flowLayoutPanel2.Controls.Add(k);
                this.compScore = compScore + k.Värde;
                lblComputerScore.Text = compScore.ToString();
            }
            /*
            if (compScore > 21 && compEss > 0)
            {
                for (int i = 0; i < compEss; i++)
                {
                    compScore -= 13;
                }
            }*/

            if (compScore <= 21 && compScore >= playerScore)
            {
                lblLooser.Text = "Du förlorade";
                button1.Enabled = false;
                btnStop.Enabled = false;
                btnNewGame.Enabled = true;
            }
            else
            {
                lblWinner.Text = "Du vann";
                button1.Enabled = false;
                btnStop.Enabled = false;
                btnNewGame.Enabled = true;
                
            }
         }
    }
}
