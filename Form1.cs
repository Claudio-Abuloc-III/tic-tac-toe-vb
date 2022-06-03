using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Application
{
    public partial class Form1 : Form
    {
        bool turn = true;

        void Enable_False()
        {
            UpLeftButton.Enabled = false;
            UpButton.Enabled = false;
            UpRightButton.Enabled = false;
            LeftButton.Enabled = false;
            MidButton.Enabled = false;
            RightButton.Enabled = false;
            DownLeftButton.Enabled = false;
            DownButton.Enabled = false;
            DownRightButton.Enabled = false;
        }
        void winner()
        {

            if (UpLeftButton.Text == "X" && UpButton.Text == "X" && UpRightButton.Text == "X") 
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (LeftButton.Text == "X" && MidButton.Text == "X" && RightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (DownLeftButton.Text == "X" && DownButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpLeftButton.Text == "X" && LeftButton.Text == "X" && DownLeftButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpButton.Text == "X" && MidButton.Text == "X" && DownButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpRightButton.Text == "X" && RightButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpLeftButton.Text == "X" && MidButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (DownLeftButton.Text == "X" && MidButton.Text == "X" && UpRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpLeftButton.Text == "X" && UpButton.Text == "X" && UpRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (LeftButton.Text == "X" && MidButton.Text == "X" && RightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (DownLeftButton.Text == "X" && DownButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpLeftButton.Text == "X" && LeftButton.Text == "X" && DownLeftButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpButton.Text == "X" && MidButton.Text == "X" && DownButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpRightButton.Text == "X" && RightButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (UpLeftButton.Text == "X" && MidButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            if (DownLeftButton.Text == "X" && MidButton.Text == "X" && UpRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");
                Enable_False();
            }
            // Player 2
            if (UpLeftButton.Text == "O" && UpButton.Text == "O" && UpRightButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }
            if (LeftButton.Text == "O" && MidButton.Text == "O" && RightButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }
            if (DownLeftButton.Text == "O" && DownButton.Text == "O" && DownRightButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }
            if (UpLeftButton.Text == "O" && LeftButton.Text == "O" && DownLeftButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }
            if (UpButton.Text == "O" && MidButton.Text == "O" && DownButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }
            if (UpRightButton.Text == "O" && RightButton.Text == "O" && DownRightButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }
            if (UpLeftButton.Text == "O" && MidButton.Text == "O" && DownRightButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }
            if (DownLeftButton.Text == "O" && MidButton.Text == "O" && UpRightButton.Text == "O")
            {
                MessageBox.Show("Player 2 wins");
                Enable_False();
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void UpLeftButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                UpLeftButton.Text = "X";
                UpLeftButton.BackColor = Color.Red;
            }
            else
            {
                UpLeftButton.Text = "O";
                UpLeftButton.BackColor = Color.Blue;
            }
            winner();
            turn = !turn;
            UpLeftButton.Enabled = false;
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                UpButton.Text = "X";
                UpButton.BackColor = Color.Red;
            }
            else
            {
                UpButton.Text = "O";
                UpButton.BackColor= Color.Blue;
            }
            winner();
            turn = !turn;
            UpButton.Enabled = false;

        }

        private void UpRightButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                UpRightButton.Text = "X";
                UpRightButton.BackColor = Color.Red;
            }
            else
            {
                UpRightButton.Text = "O";
                UpRightButton.BackColor = Color.Blue;
            }
            winner();
            turn = !turn;
            UpRightButton.Enabled = false;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                LeftButton.Text = "X";
                LeftButton.BackColor = Color.Red;
            }
            else
            {
                LeftButton.Text = "O";
                LeftButton.BackColor= Color.Blue;
            }
            winner();
            turn = !turn;
            LeftButton.Enabled = false;
        }

        private void MidButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                MidButton.Text = "X";
                MidButton.BackColor = Color.Red;
            }
            else
            {
                MidButton.Text = "O";
                MidButton.BackColor= Color.Blue;
            }
            winner();
            turn = !turn;
            MidButton.Enabled = false;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                RightButton.Text = "X";
                RightButton.BackColor = Color.Red;
            }
            else
            {
                RightButton.Text = "O";
                RightButton.BackColor = Color.Blue;
            }
            winner();
            turn = !turn;
            RightButton.Enabled = false;
        }

        private void DownLeftButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                DownLeftButton.Text = "X";
                DownLeftButton.BackColor = Color.Red;
            }
            else
            {
                DownLeftButton.Text = "O";
                DownLeftButton.BackColor = Color.Blue;
            }
            winner();
            turn = !turn;
            DownLeftButton.Enabled = false;
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                DownButton.Text = "X";
                DownButton.BackColor = Color.Red;
            }
            else
            {
                DownButton.Text = "O";
                DownButton.BackColor = Color.Blue;
            }
            winner();
            turn = !turn;
            DownButton.Enabled = false;
        }

        private void DownRightButton_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                DownRightButton.Text = "X";
                DownRightButton.BackColor = Color.Red;
            }
            else
            {
                DownRightButton.Text = "O";
                DownRightButton.BackColor = Color.Blue;
            }
            winner();
            turn = !turn;
            DownRightButton.Enabled = false;   
            //deciding the winner
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UpLeftButton.Enabled = true;
            UpButton.Enabled = true;
            UpRightButton.Enabled = true;
            LeftButton.Enabled = true;
            MidButton.Enabled = true;
            RightButton.Enabled = true;
            DownLeftButton.Enabled = true;
            DownButton.Enabled = true;
            DownRightButton.Enabled = true;

            UpLeftButton.Text = "";
            UpButton.Text = "";
            UpRightButton.Text = "";
            LeftButton.Text = "";
            MidButton.Text = "";
            RightButton.Text = "";
            DownLeftButton.Text = "";
            DownButton.Text = "";
            DownRightButton.Text = "";

            UpLeftButton.BackColor = Color.White;
            UpButton.BackColor = Color.White;
            UpRightButton.BackColor = Color.White;
            LeftButton.BackColor = Color.White;
            MidButton.BackColor = Color.White;
            RightButton.BackColor = Color.White;
            DownLeftButton.BackColor = Color.White;
            DownButton.BackColor = Color.White;
            DownRightButton.BackColor = Color.White;
        }
    }
}
