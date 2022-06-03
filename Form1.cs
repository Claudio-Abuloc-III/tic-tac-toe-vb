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
            //deciding the winner
        }
    }
}
