﻿namespace Tic_Tac_Toe_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
            this.Box = new System.Windows.Forms.GroupBox();
            this.UpLeftButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.UpRightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.MidButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownLeftButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.DownRightButton = new System.Windows.Forms.Button();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Controls.Add(this.DownRightButton);
            this.Box.Controls.Add(this.DownButton);
            this.Box.Controls.Add(this.DownLeftButton);
            this.Box.Controls.Add(this.RightButton);
            this.Box.Controls.Add(this.MidButton);
            this.Box.Controls.Add(this.LeftButton);
            this.Box.Controls.Add(this.UpRightButton);
            this.Box.Controls.Add(this.UpButton);
            this.Box.Controls.Add(this.UpLeftButton);
            this.Box.Location = new System.Drawing.Point(12, 12);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(607, 540);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            // 
            // UpLeftButton
            // 
            this.UpLeftButton.Location = new System.Drawing.Point(34, 83);
            this.UpLeftButton.Name = "UpLeftButton";
            this.UpLeftButton.Size = new System.Drawing.Size(166, 125);
            this.UpLeftButton.TabIndex = 0;
            this.UpLeftButton.UseVisualStyleBackColor = true;
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(215, 83);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(166, 125);
            this.UpButton.TabIndex = 1;
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // UpRightButton
            // 
            this.UpRightButton.Location = new System.Drawing.Point(396, 83);
            this.UpRightButton.Name = "UpRightButton";
            this.UpRightButton.Size = new System.Drawing.Size(166, 125);
            this.UpRightButton.TabIndex = 2;
            this.UpRightButton.UseVisualStyleBackColor = true;
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(34, 223);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(166, 125);
            this.LeftButton.TabIndex = 3;
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // MidButton
            // 
            this.MidButton.Location = new System.Drawing.Point(215, 223);
            this.MidButton.Name = "MidButton";
            this.MidButton.Size = new System.Drawing.Size(166, 125);
            this.MidButton.TabIndex = 4;
            this.MidButton.UseVisualStyleBackColor = true;
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(396, 223);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(166, 125);
            this.RightButton.TabIndex = 5;
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // DownLeftButton
            // 
            this.DownLeftButton.Location = new System.Drawing.Point(34, 366);
            this.DownLeftButton.Name = "DownLeftButton";
            this.DownLeftButton.Size = new System.Drawing.Size(166, 125);
            this.DownLeftButton.TabIndex = 6;
            this.DownLeftButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(215, 366);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(166, 125);
            this.DownButton.TabIndex = 7;
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // DownRightButton
            // 
            this.DownRightButton.Location = new System.Drawing.Point(396, 366);
            this.DownRightButton.Name = "DownRightButton";
            this.DownRightButton.Size = new System.Drawing.Size(166, 125);
            this.DownRightButton.TabIndex = 8;
            this.DownRightButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 564);
            this.Controls.Add(this.Box);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Button DownRightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button DownLeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button MidButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button UpRightButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button UpLeftButton;
    }
}
