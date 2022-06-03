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
            }
            else
            {
                UpButton.Text = "O";
            }
        }

        private void UpRightButton_Click(object sender, EventArgs e)
        {
            if (UpRightButton.Text == "")
            {
                UpRightButton.Text = "X";
            }
            else
            {
                UpRightButton.Text = "O";
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (LeftButton.Text == "")
            {
                LeftButton.Text = "X";
            }
            else
            {
                LeftButton.Text = "O";
            }
        }

        private void MidButton_Click(object sender, EventArgs e)
        {
            if (MidButton.Text == "")
            {
                MidButton.Text = "X";
            }
            else
            {
                MidButton.Text = "O";
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (RightButton.Text == "")
            {
                RightButton.Text = "X";
            }
            else
            {
                RightButton.Text = "O";
            }
        }

        private void DownLeftButton_Click(object sender, EventArgs e)
        {
            if (DownLeftButton.Text == "")
            {
                DownLeftButton.Text = "X";
            }
            else
            {
                DownLeftButton.Text = "O";
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (DownButton.Text == "")
            {
                DownButton.Text = "X";
            }
            else
            {
                DownButton.Text = "O";
            }
        }

        private void DownRightButton_Click(object sender, EventArgs e)
        {
            if (DownRightButton.Text == "")
            {
                DownRightButton.Text = "X";
            }
            else
            {
                DownRightButton.Text = "O";
            }
        }
    }
}
