
namespace TicTacToe_project___EH
{
    partial class TicTacToe
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblReady = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.txtFirstPlayer = new System.Windows.Forms.TextBox();
            this.txtSecondPlayer = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblWinA = new System.Windows.Forms.Label();
            this.lblWinB = new System.Windows.Forms.Label();
            this.txtWinACount = new System.Windows.Forms.TextBox();
            this.txtWinBCount = new System.Windows.Forms.TextBox();
            this.pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(24, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(291, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Tic-Tac-Toe Game!";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(24, 54);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(271, 16);
            this.lblNames.TabIndex = 1;
            this.lblNames.Text = "Please enter names below before beginning";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "(First name entered will be assigned the X icon and will go first.)";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.ForeColor = System.Drawing.Color.Blue;
            this.lblFirst.Location = new System.Drawing.Point(24, 123);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(104, 13);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First Player Name -->";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.ForeColor = System.Drawing.Color.Blue;
            this.lblSecond.Location = new System.Drawing.Point(24, 161);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(125, 13);
            this.lblSecond.TabIndex = 4;
            this.lblSecond.Text = "Second Player Name --> ";
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.Location = new System.Drawing.Point(24, 213);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(235, 13);
            this.lblReady.TabIndex = 5;
            this.lblReady.Text = "When ready to play, click this button -->";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(20, 25);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(70, 13);
            this.lblTurn.TabIndex = 6;
            this.lblTurn.Text = "It\'s your turn, ";
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Enabled = false;
            this.txtCurrentPlayer.Location = new System.Drawing.Point(132, 18);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPlayer.TabIndex = 7;
            // 
            // txtFirstPlayer
            // 
            this.txtFirstPlayer.Location = new System.Drawing.Point(202, 120);
            this.txtFirstPlayer.Name = "txtFirstPlayer";
            this.txtFirstPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtFirstPlayer.TabIndex = 8;
            // 
            // txtSecondPlayer
            // 
            this.txtSecondPlayer.Location = new System.Drawing.Point(202, 154);
            this.txtSecondPlayer.Name = "txtSecondPlayer";
            this.txtSecondPlayer.Size = new System.Drawing.Size(100, 20);
            this.txtSecondPlayer.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 628);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "We wanna stop the game!!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOk2
            // 
            this.btnOk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk2.Location = new System.Drawing.Point(322, 156);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(35, 23);
            this.btnOk2.TabIndex = 11;
            this.btnOk2.Text = "OK";
            this.btnOk2.UseVisualStyleBackColor = false;
            this.btnOk2.Click += new System.EventHandler(this.btnOk2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(295, 208);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Let\'s Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOK1
            // 
            this.btnOK1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOK1.Location = new System.Drawing.Point(322, 117);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(35, 23);
            this.btnOK1.TabIndex = 13;
            this.btnOK1.Text = "OK";
            this.btnOK1.UseVisualStyleBackColor = false;
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click_1);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Controls.Add(this.txtCurrentPlayer);
            this.pnlBoard.Controls.Add(this.lblTurn);
            this.pnlBoard.Location = new System.Drawing.Point(27, 237);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(512, 385);
            this.pnlBoard.TabIndex = 14;
            this.pnlBoard.Visible = false;
            this.pnlBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBoard_Paint);
            // 
            // lblWinA
            // 
            this.lblWinA.AutoSize = true;
            this.lblWinA.Location = new System.Drawing.Point(378, 123);
            this.lblWinA.Name = "lblWinA";
            this.lblWinA.Size = new System.Drawing.Size(34, 13);
            this.lblWinA.TabIndex = 15;
            this.lblWinA.Text = "Wins:";
            // 
            // lblWinB
            // 
            this.lblWinB.AutoSize = true;
            this.lblWinB.Location = new System.Drawing.Point(378, 161);
            this.lblWinB.Name = "lblWinB";
            this.lblWinB.Size = new System.Drawing.Size(34, 13);
            this.lblWinB.TabIndex = 16;
            this.lblWinB.Text = "Wins:";
            // 
            // txtWinACount
            // 
            this.txtWinACount.Location = new System.Drawing.Point(418, 120);
            this.txtWinACount.Name = "txtWinACount";
            this.txtWinACount.ReadOnly = true;
            this.txtWinACount.Size = new System.Drawing.Size(24, 20);
            this.txtWinACount.TabIndex = 17;
            // 
            // txtWinBCount
            // 
            this.txtWinBCount.Location = new System.Drawing.Point(418, 158);
            this.txtWinBCount.Name = "txtWinBCount";
            this.txtWinBCount.ReadOnly = true;
            this.txtWinBCount.Size = new System.Drawing.Size(24, 20);
            this.txtWinBCount.TabIndex = 18;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 652);
            this.Controls.Add(this.txtWinBCount);
            this.Controls.Add(this.txtWinACount);
            this.Controls.Add(this.lblWinB);
            this.Controls.Add(this.lblWinA);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSecondPlayer);
            this.Controls.Add(this.txtFirstPlayer);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblWelcome);
            this.Name = "TicTacToe";
            this.Text = "Tic-Tac-Toe";
            this.pnlBoard.ResumeLayout(false);
            this.pnlBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
        private System.Windows.Forms.TextBox txtFirstPlayer;
        private System.Windows.Forms.TextBox txtSecondPlayer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOk2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblWinA;
        private System.Windows.Forms.Label lblWinB;
        private System.Windows.Forms.TextBox txtWinACount;
        private System.Windows.Forms.TextBox txtWinBCount;
    }
}

