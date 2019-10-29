using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Gesture
    {
        //MEMBER VARIABLES
        public string gestureName;

        //CONSTRUCTOR
        public Gesture()
        {

        }

        //MEMBER METHODS
        public abstract bool WinsAgainst(Gesture comparisonGestureChoice);
    }
}
