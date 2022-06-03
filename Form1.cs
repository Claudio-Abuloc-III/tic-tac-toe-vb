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
        public Form1()
        {
            InitializeComponent();
        }

        private void UpLeftButton_Click(object sender, EventArgs e)
        {
            if (UpLeftButton.Text == "")
            {
                UpLeftButton.Text = "X";
                UpLeftButton.BackColor = Color.Red;
            }
            else
            {
                UpLeftButton.Text = "O";
                UpLeftButton.BackColor = Color.Blue;
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (UpButton.Text == "")
            {
                UpButton.Text = "X";
                UpButton.BackColor = Color.Red;
            }
            else
            {
                UpButton.Text = "O";
                UpButton.BackColor= Color.Blue;
            }
        }

        private void UpRightButton_Click(object sender, EventArgs e)
        {
            if (UpRightButton.Text == "")
            {
                UpRightButton.Text = "X";
                UpRightButton.BackColor = Color.Red;
            }
            else
            {
                UpRightButton.Text = "O";
                UpRightButton.BackColor = Color.Blue;
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (LeftButton.Text == "")
            {
                LeftButton.Text = "X";
                LeftButton.BackColor = Color.Red;
            }
            else
            {
                LeftButton.Text = "O";
                LeftButton.BackColor= Color.Blue;
            }
        }

        private void MidButton_Click(object sender, EventArgs e)
        {
            if (MidButton.Text == "")
            {
                MidButton.Text = "X";
                MidButton.BackColor = Color.Red;
            }
            else
            {
                MidButton.Text = "O";
                MidButton.BackColor= Color.Blue;
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (RightButton.Text == "")
            {
                RightButton.Text = "X";
                RightButton.BackColor = Color.Red;
            }
            else
            {
                RightButton.Text = "O";
                RightButton.BackColor = Color.Blue;
            }
        }

        private void DownLeftButton_Click(object sender, EventArgs e)
        {
            if (DownLeftButton.Text == "")
            {
                DownLeftButton.Text = "X";
                DownLeftButton.BackColor = Color.Red;
            }
            else
            {
                DownLeftButton.Text = "O";
                DownLeftButton.BackColor = Color.Blue;
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (DownButton.Text == "")
            {
                DownButton.Text = "X";
                DownButton.BackColor = Color.Red;
            }
            else
            {
                DownButton.Text = "O";
                DownButton.BackColor = Color.Blue;
            }
        }

        private void DownRightButton_Click(object sender, EventArgs e)
        {
            if (DownRightButton.Text == "")
            {
                DownRightButton.Text = "X";
                DownRightButton.BackColor = Color.Red;
            }
            else
            {
                DownRightButton.Text = "O";
                DownRightButton.BackColor = Color.Blue;
            }
            //problem with player turn to push the button
            //deciding the winner
            //stop the button after click
        }
    }
}
