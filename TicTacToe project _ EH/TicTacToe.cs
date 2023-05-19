using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// TicTacToe Form
// Class that models the attributes and methods for one player
// Responsible for data stores and methods required to model a player

// Eric Hernandez
// January 30, 2021 (Rev 1)

namespace TicTacToe_project___EH
{
    public partial class TicTacToe : Form
    {
        // private PlayerModel players
        private List<PlayerModel> playersList = new List<PlayerModel>(2);
        private PlayerModel currentPlayer;
        private BoardModel internalBoardRep = new BoardModel();

        private string playerAName;
        private string playerBName;
        private Button[,] newButton = new Button[3, 3];

        int turnCount = 0;   // count of turns taken.  if reaches 9 and no winnner 
                             // then we have a draw
        int gameCount = 0;   // counts number of games played


        public TicTacToe()
        {
            InitializeComponent();
        }
        // Switch players
        private void alternateTurn()
        {
            if (currentPlayer.Icon == playersList[0].Icon)
            {
                currentPlayer = playersList[1];
            }
            else
            {
                currentPlayer = playersList[0];
                
            }
            txtCurrentPlayer.Text = currentPlayer.Name;
        } // end alternateTurn

        public void displayCurrentPlayer()
        {
            txtCurrentPlayer.Text = currentPlayer.Name + " : " + currentPlayer.Icon;
        } // end displayCurrentPlayer



        // Click handler for player1's OK button
        // Ensures that some non-blank characters have been entered
        private void btnOK1_Click(object sender, EventArgs e)
        {
            playerAName = txtFirstPlayer.Text;
            if (playerAName == "")
            {
                MessageBox.Show("First player name" + " is a required field. Reenter Name!",
                    "Entry Error!");
                txtFirstPlayer.Focus();
            }
            else
            {
                txtFirstPlayer.Visible = true;
                lblSecond.Visible = true;
                btnOk2.Visible = true;
                txtSecondPlayer.Focus();
            }
        } // end txtPlayerAName Handler


      
        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            playerAName = txtFirstPlayer.Text;
            playerBName = txtSecondPlayer.Text;


           

            // Double check to see if names are valid
            if ((playerAName.Length > 0 && playerBName.Length > 0) && (playerAName.ToLower() != playerBName.ToLower())
                 && (playerAName != playerBName))
            {
                // If names OK, create instances of the two players.  
                //    Then dynamically create the board
                PlayerModel p;
                p = new PlayerModel(playerAName, 'X');
                playersList.Add(p);
                p = new PlayerModel(playerBName, 'O');
                playersList.Add(p); ;

                currentPlayer = playersList[0];
                
                
                txtCurrentPlayer.Text = txtFirstPlayer.Text;
                txtCurrentPlayer.Enabled = true;
                pnlBoard.Visible = true;
            } // end if
            else
            {
                MessageBox.Show("One or both names are blank or names are the same. Reenter name(s).","Entry Error!");
                playerAName = "";
                playerBName = "";
                txtFirstPlayer.Focus();
                txtFirstPlayer.Enabled = true;
                txtSecondPlayer.Enabled = true;
                btnOK1.Enabled = true;
                btnOk2.Enabled = true;
            } // end else

            

        }

        private void btnOk2_Click(object sender, EventArgs e)
        {
            playerBName = txtSecondPlayer.Text;
            if (playerBName == "")
            {
                MessageBox.Show("Player 2's name is empty, please enter a Name");
                txtSecondPlayer.Focus();
            }
            else if ((playerAName == playerBName))
            {
                MessageBox.Show("Both Players names' are identical.  Please make sure your names are different");
            }
            else
            {
                txtSecondPlayer.Enabled = false;
                btnOk2.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK1_Click_1(object sender, EventArgs e)
        {
            playerAName = txtFirstPlayer.Text;
            if (playerAName == "")
            {
                MessageBox.Show("Player 1's name is empty, please enter a Name");
                txtFirstPlayer.Focus();
            }
            else
            {
                txtFirstPlayer.Enabled = false;
                btnOK1.Enabled = false;
            }
        }
        // This is the handler for all 9 Tic Tac Toe Buttons
        // It uses sender argument to determine which Tic Tac Toe button was selected
        // The argument is of type object and must be recast to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            int rowID = convertCharToInt(((Button)sender).Name[3]);
            int colID = convertCharToInt(((Button)sender).Name[4]);
            MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;
            internalBoardRep.recordTurn(currentPlayer, cellID);
            string thisToken = (currentPlayer.Icon).ToString();
            ((Button)sender).Text = thisToken;
            if (thisToken == "X") ((Button)sender).ForeColor = Color.Orange;
            //btnSpace[rowID,colID].Enabled = false;
            ((Button)sender).Enabled = false;

            if (internalBoardRep.hasPlayerWon(currentPlayer.Icon))
            {
                MessageBox.Show("Congratulations " + currentPlayer.Name + ". You won!!!");
                currentPlayer.won();
                if (currentPlayer.Icon == 'X') txtWinACount.Text = currentPlayer.Wins.ToString();
                else txtWinBCount.Text = currentPlayer.Wins.ToString();
                pnlBoard.Visible = false;
                DialogResult playAgain = MessageBox.Show("Do you wanna Play Again?", "Game Over!", MessageBoxButtons.YesNo);
                if (playAgain == DialogResult.Yes)
                {
                    
                    internalBoardRep.resetGame();
                    turnCount = 0;
                    pnlBoard.Visible = false;
                    return;
                    //this clears the board and it restarts the game
                    //Extra Note: I Couldn't get the resetBoard, sooooooo here's the option incase one day down the line i can get it to work.
                }
                else if (playAgain == DialogResult.No)
                {

                    this.Close();
                    
                }
                
            } // end hasPlayerWon then alternative
            else
            {
                turnCount++;
                if (turnCount >= 9)
                {
                    pnlBoard.Visible = false;
                    DialogResult playAgain = MessageBox.Show("Do you wanna Play Again?", "Game over.  We have a draw.", MessageBoxButtons.YesNo);
                    // This detects the tie and a message will pop up.
                    if (playAgain == DialogResult.Yes)
                    {
                        
                        internalBoardRep.resetGame();
                        turnCount = 0;
                        return;
                        //clears the board and it restarts the game
                    }
                    else if (playAgain == DialogResult.No)
                    {
                        
                        this.Close();
                    }
                    
                } // end turnCount if
            } // end else
            alternateTurn();
        } // end button clickhandler 

        

        int convertCharToInt(Char c)
        {
            return ((int)(c) - (int)('0'));
        }

        private void pnlBoard_Paint(object sender, PaintEventArgs e)
        {
            
            //pnlBoard.Visible = false;
            Size size = new Size(75, 75);
            Point loc = new Point(0, 0);
            int padding = 25;

            Button[,] btnSpace = new Button[2, 2];

            int topMargin = 40;
            //this creates the font, size, and the eventHandler for each new button.
            for (int row = 0; row <= 2; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 80;
                for (int col = 0; col <= 2; col++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(extraLeftPadding + col * (size.Width + padding), loc.Y);
                    newButton.Size = size;
                    newButton.Font = new Font("Arial", 48, FontStyle.Bold);
                    newButton.Text = "";
                    newButton.Enabled = true;
                    newButton.Name = "btn" + row + col;
                    newButton.Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlBoard.Controls.Add(newButton);

                } // end for col
            } // end for row
        }
        
    }


}