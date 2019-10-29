using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Spock : Gesture
    {
        //MEMBER VARIABLES

        //CONSTRUCTOR
        public Spock()
        {
            gestureName = "spock";
        }

        //MEMBER METHODS
        public override bool WinsAgainst(Gesture comparisonGestureChoice)
        {
            if (comparisonGestureChoice.gestureName == "scissors" || comparisonGestureChoice.gestureName == "rock")
            {
                return true;
            }
            return false;
        }

    }
}
