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
        public string name;
        public Gesture gesture;
        public int score;

        //CONSTRUCTOR
        public Player()
        {
        
        }

        //MEMBER METHODS
        public abstract void SelectGesture();
        public abstract void SelectPlayerName();
        
    }
}
