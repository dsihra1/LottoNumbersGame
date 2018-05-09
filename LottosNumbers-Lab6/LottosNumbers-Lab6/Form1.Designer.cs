namespace LottosNumbers_Lab6
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
            this.grpPlay = new System.Windows.Forms.GroupBox();
            this.lblPlayerNumbers = new System.Windows.Forms.Label();
            this.btnPlayerButton = new System.Windows.Forms.Button();
            this.grpWinner = new System.Windows.Forms.GroupBox();
            this.lblWinningNumbers = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.grpMatchNum = new System.Windows.Forms.GroupBox();
            this.lblMatch = new System.Windows.Forms.Label();
            this.grpPlay.SuspendLayout();
            this.grpWinner.SuspendLayout();
            this.grpMatchNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlay
            // 
            this.grpPlay.Controls.Add(this.btnPlayerButton);
            this.grpPlay.Controls.Add(this.lblPlayerNumbers);
            this.grpPlay.Location = new System.Drawing.Point(155, 33);
            this.grpPlay.Name = "grpPlay";
            this.grpPlay.Size = new System.Drawing.Size(200, 100);
            this.grpPlay.TabIndex = 0;
            this.grpPlay.TabStop = false;
            this.grpPlay.Text = "Your Numbers";
            // 
            // lblPlayerNumbers
            // 
            this.lblPlayerNumbers.AutoSize = true;
            this.lblPlayerNumbers.Location = new System.Drawing.Point(49, 37);
            this.lblPlayerNumbers.Name = "lblPlayerNumbers";
            this.lblPlayerNumbers.Size = new System.Drawing.Size(109, 13);
            this.lblPlayerNumbers.TabIndex = 0;
            this.lblPlayerNumbers.Text = "00 00 00 00 00 00 00";
            // 
            // btnPlayerButton
            // 
            this.btnPlayerButton.Location = new System.Drawing.Point(64, 71);
            this.btnPlayerButton.Name = "btnPlayerButton";
            this.btnPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerButton.TabIndex = 1;
            this.btnPlayerButton.Text = "Generate";
            this.btnPlayerButton.UseVisualStyleBackColor = true;
            this.btnPlayerButton.Click += new System.EventHandler(this.btnPlayerButton_Click);
            // 
            // grpWinner
            // 
            this.grpWinner.Controls.Add(this.btnPlay);
            this.grpWinner.Controls.Add(this.lblWinningNumbers);
            this.grpWinner.Location = new System.Drawing.Point(155, 139);
            this.grpWinner.Name = "grpWinner";
            this.grpWinner.Size = new System.Drawing.Size(200, 100);
            this.grpWinner.TabIndex = 1;
            this.grpWinner.TabStop = false;
            this.grpWinner.Text = "Winning Number";
            // 
            // lblWinningNumbers
            // 
            this.lblWinningNumbers.AutoSize = true;
            this.lblWinningNumbers.Location = new System.Drawing.Point(49, 39);
            this.lblWinningNumbers.Name = "lblWinningNumbers";
            this.lblWinningNumbers.Size = new System.Drawing.Size(109, 13);
            this.lblWinningNumbers.TabIndex = 0;
            this.lblWinningNumbers.Text = "00 00 00 00 00 00 00";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(64, 71);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // grpMatchNum
            // 
            this.grpMatchNum.Controls.Add(this.lblMatch);
            this.grpMatchNum.Location = new System.Drawing.Point(155, 245);
            this.grpMatchNum.Name = "grpMatchNum";
            this.grpMatchNum.Size = new System.Drawing.Size(200, 67);
            this.grpMatchNum.TabIndex = 2;
            this.grpMatchNum.TabStop = false;
            this.grpMatchNum.Text = "Matching Numbers";
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Location = new System.Drawing.Point(95, 35);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(19, 13);
            this.lblMatch.TabIndex = 0;
            this.lblMatch.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 367);
            this.Controls.Add(this.grpMatchNum);
            this.Controls.Add(this.grpWinner);
            this.Controls.Add(this.grpPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPlay.ResumeLayout(false);
            this.grpPlay.PerformLayout();
            this.grpWinner.ResumeLayout(false);
            this.grpWinner.PerformLayout();
            this.grpMatchNum.ResumeLayout(false);
            this.grpMatchNum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLotto;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.GroupBox grpComputer;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.GroupBox grpMatching;
        private System.Windows.Forms.Label lblMatching;
        private System.Windows.Forms.Label lblPlayerNumber;
        private System.Windows.Forms.Label lblComputerNumber;
        private System.Windows.Forms.GroupBox grpPlay;
        private System.Windows.Forms.Button btnPlayerButton;
        private System.Windows.Forms.Label lblPlayerNumbers;
        private System.Windows.Forms.GroupBox grpWinner;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblWinningNumbers;
        private System.Windows.Forms.GroupBox grpMatchNum;
        private System.Windows.Forms.Label lblMatch;
    }
}

