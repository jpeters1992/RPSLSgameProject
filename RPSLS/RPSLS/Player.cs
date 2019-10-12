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
        public int score;
        public string name;
        public string gesture;

        //CONSTRUCTOR
        public Player()
        {
            score = 0;
        }

        //MEMBER METHODS

        public abstract void SelectGesture();
        public abstract void SelectHumanPlayerName();
        
    }
}
