using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

// Board model class
// Class that models the attributes and methods for one player
// Responsible for data stores and methods required to model a player

// Frank L. Friedman
// January 11, 2016 (Rev 3)

namespace TicTacToe_project___EH
{
    class BoardModel
    {
        const int SIZE = 9;                                 // Size of board representation

        private char[] internalBoardRep = new char[SIZE];  // The board representation itself

        // Constructor - resets the game
        public BoardModel()
        {
            resetGame();
        } // end New


        // Records information each time a player takes a turn
        public void recordTurn
            (PlayerModel currentPlayer,  // IN: represents the player (object) making the current move 
             int cellId)                 // IN: represents ID of the cell selected by the player
        {
            internalBoardRep[cellId] = currentPlayer.Icon;
            return;
        } // end recordTurn


        // Resets the board for a new game
        public void resetGame()
        {
            clearInternalBoardRep();
        } // end resetGame


        // Actually clears each cell in the Board by resetting it to Blank
        public void clearInternalBoardRep()
        {
            for (int i = 0; i < SIZE; i++)
            {
                internalBoardRep[i] = ' ';
            }
        } // end clearInternalBoardRep   


        // Determines if there is a winner by checking rows, columns and diagonals
        // Returns: True if there is a winner and False otherwise
        public Boolean hasPlayerWon
            (char currentPlayerIcon)      // IN: icon for the current player
        {
            Boolean result = false;
            if (isRowWin(currentPlayerIcon) || isColumnWin(currentPlayerIcon) || isDiagonalWin(currentPlayerIcon))
            {
                result = true;
            }
            return result;
        } // end hasPlayerWon


        // Checks rows for a winner
        private Boolean isRowWin
            (Char currentPlayerIcon)   // IN: icon of curent player
        {
            return isWin(0, 1, 2, currentPlayerIcon) || isWin(3, 4, 5, currentPlayerIcon) || isWin(6, 7, 8, currentPlayerIcon);
        } // end isRowWin


        // Checks columns for a winner
        private Boolean isColumnWin
            (Char currentPlayerIcon)   // IN: icon of current player
        {
            return isWin(0, 3, 6, currentPlayerIcon) || isWin(1, 4, 7, currentPlayerIcon) || isWin(2, 5, 8, currentPlayerIcon);
        } // end isRowWin


        // Checks diagonals for a winner
        private Boolean isDiagonalWin
            (char currentPlayerIcon)   // IN: icon of current player
        {
            return isWin(0, 4, 8, currentPlayerIcon) || isWin(2, 4, 6, currentPlayerIcon);
        } // end isdiagonalWin


        // Checks the three Tic-Tac-Toe Board blocks to see if they contain the same character 
        private Boolean isWin
            (int block1, int block2, int block3,   // IN: indexes of the three blocks to be checked 
             char currentPlayerIcon)               // IN: icon of current player
        {
            Boolean result = false;
            if (internalBoardRep[block1] == currentPlayerIcon &&
                internalBoardRep[block2] == currentPlayerIcon &&
                internalBoardRep[block3] == currentPlayerIcon)
            {
                result = true;
            }
            return result;
        } // end isWin

        
       
    }

}

