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

        void winner()
        {
            // Player 1 wins
            if (UpLeftButton.Text == "X" && UpButton.Text == "X" && UpRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (LeftButton.Text == "X" && MidButton.Text == "X" && RightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (DownLeftButton.Text == "X" && DownButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpLeftButton.Text == "X" && LeftButton.Text == "X" && DownLeftButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpButton.Text == "X" && MidButton.Text == "X" && DownButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpRightButton.Text == "X" && RightButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpLeftButton.Text == "X" && MidButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (DownLeftButton.Text == "X" && MidButton.Text == "X" && UpRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpLeftButton.Text == "X" && UpButton.Text == "X" && UpRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (LeftButton.Text == "X" && MidButton.Text == "X" && RightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (DownLeftButton.Text == "X" && DownButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpLeftButton.Text == "X" && LeftButton.Text == "X" && DownLeftButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpButton.Text == "X" && MidButton.Text == "X" && DownButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpRightButton.Text == "X" && RightButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (UpLeftButton.Text == "X" && MidButton.Text == "X" && DownRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

            }
            if (DownLeftButton.Text == "X" && MidButton.Text == "X" && UpRightButton.Text == "X")
            {
                MessageBox.Show("Player 1 wins");

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
            turn= !turn;
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
            turn = !turn;
            DownRightButton.Enabled = false;   
            //deciding the winner
        }
    }
}
