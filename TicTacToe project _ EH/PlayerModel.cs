// Player model class
// Class that models the attributes and methods for one player
// Responsible for data stores and methods required to model a player

// Frank L. Friedman
// January 11, 2016 (Rev 3)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TicTacToe_project___EH
{

        class PlayerModel
        {
            private string hiddenName;
            private int hiddenWins;
            private char hiddenIcon;

            public PlayerModel(string name, char icon)
            {
                hiddenName = name;
                hiddenIcon = icon;
                hiddenWins = 0;
            } // end New

            // Read only properties
            public char Icon
            {
                get { return hiddenIcon; }
            } // end property Icon

            public string Name
            {
                get { return hiddenName; }
            } // end property Name

            public int Wins
            {
                get { return hiddenWins; }
            } // end property Wins


            // Increment number of wins for this player
            public void won()
            {
                hiddenWins = hiddenWins + 1;
            } // end isWin

        } // end class PlayerModel
    } // end namespace CIS_TicTacToeV1

