﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Paper : Gesture
    {
        //MEMBER VARIABLES

        //CONSTRUCTOR
        public Paper()
        {
            gestureName = "paper";
        }

        //MEMBER METHODS
        public override bool WinsAgainst(Gesture comparisonGestureChoice)
        {
            if (comparisonGestureChoice.gestureName == "spock" || comparisonGestureChoice.gestureName == "rock")
            {
                return true;
            }
            return false;
        }
    }
}
