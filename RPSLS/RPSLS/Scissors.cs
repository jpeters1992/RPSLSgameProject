using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Scissors : Gesture
    {
        //MEMBER VARIABLES

        //CONSTRUCTOR
        public Scissors()
        {
            gestureName = "scissors";
        }

        //MEMBER METHODS
        public override bool WinsAgainst(Gesture comparisonGestureChoice)
        {
            if (comparisonGestureChoice.gestureName == "lizard" || comparisonGestureChoice.gestureName == "paper")
            {
                return true;
            }
            return false;
        }
    }
}
