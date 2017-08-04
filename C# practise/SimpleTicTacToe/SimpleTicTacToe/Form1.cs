using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTicTacToe
{
    public partial class Form1 : Form
    {
        private bool _turn = true; // true = x  , false = o
        private int _turncount = 0;

        public Form1()
        {
            InitializeComponent();

        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple version of Tic Tac Toe. \nIt's made by Joshua Latusia.");
        }

        private void closeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            if (_turn)
            {
                b.Text = "x";
                turn_lbl.Text = "o";
            }

            else
            {
                b.Text = "o";
                turn_lbl.Text = "x";
            }
            b.Enabled = false;
            CheckForWinner();
            _turn = !_turn;

            
            _turncount++;

        }

        private void CheckForWinner()
        {
            bool winner = false;

            // Horizontal checking
            if (button_A1.Text == button_A2.Text && button_A2.Text == button_A3.Text && !button_A1.Enabled)
                winner = true;
            else if (button_B1.Text == button_B2.Text && button_B2.Text == button_B3.Text && !button_B1.Enabled)
                winner = true;
            else if (button_C1.Text == button_C2.Text && button_C2.Text == button_C3.Text && !button_C1.Enabled)
                winner = true;

            // Vertical Checking
            else if (button_A1.Text == button_B1.Text && button_B1.Text == button_C1.Text && !button_A1.Enabled)
                winner = true;
            else if (button_A2.Text == button_B2.Text && button_B2.Text == button_C2.Text && !button_A2.Enabled)
                winner = true;
            else if (button_A3.Text == button_B3.Text && button_B3.Text == button_C3.Text && !button_A3.Enabled)
                winner = true;

            // Diagonal Checking
            else if (button_A1.Text == button_B2.Text && button_B2.Text == button_C3.Text && !button_A1.Enabled)
                winner = true;
            else if (button_A3.Text == button_B2.Text && button_B2.Text == button_C1.Text && !button_A3.Enabled)
                winner = true;

            string winnerLetter = _turn ? "x" : "o";




            if (winner)
            {
                SetAllButtons(false);
                MessageBox.Show("The Winner is : " + winnerLetter, "Heujj");
                NewGame();
                return;
            }

            if (_turncount == 8)
            {
                MessageBox.Show("It's a draw", "Heujj");
                NewGame();
                return;
            }


        }

        private void SetAllButtons(bool state)
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button) c;
                    b.Enabled = state;
                }
                catch (Exception)
                {

                }
            }
        }

        private void NewGame()
        {
            _turn = true;
            _turncount = 0;
            SetAllButtons(true);


        }




    }
}
