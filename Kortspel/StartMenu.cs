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
    
    public partial class StartMenu : Form
    {
        
        
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btn1pl_Click(object sender, EventArgs e)
        {
            Form1 singleplayer = new Form1();
            singleplayer.ShowDialog();
            

        }

        private void btn2pl_Click(object sender, EventArgs e)
        {
            Form2 multiplayer = new Form2();
            multiplayer.ShowDialog();

        }

        private void btnInstr_Click(object sender, EventArgs e)
        {
            InstructionsForm instrForm = new InstructionsForm();
            instrForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
