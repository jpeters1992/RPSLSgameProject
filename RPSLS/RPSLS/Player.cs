using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {

        //MEMBER VARIABLES
        public string playerName;
        public Gesture playerGesture;
        public int playerScore;
        public bool isWinner;

        //CONSTRUCTOR
        public Player()
        {
            SelectPlayerName();
            playerGesture = null;
            playerScore = 0;
            isWinner = false;
        
        }

        //MEMBER METHODS
        public abstract void SelectGesture();
        public abstract void SelectPlayerName();
        
    }
}
