using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Rock : Gesture
    {
        //MEMBER VARIABLES

        //CONSTRUCTOR
        public Rock()
        {
            gestureName = "rock";
        }

        //MEMBER METHODS
        public override bool WinsAgainst(Gesture comparisonGestureChoice)
        {
            if (comparisonGestureChoice.gestureName == "scissors" || comparisonGestureChoice.gestureName == "lizard")
            {
                return true;
            }
            return false;
        }
    }
}
