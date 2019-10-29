﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Lizard : Gesture
    {
        //MEMBER VARIABLES

        //CONSTRUCTOR
        public Lizard()
        {
            gestureName = "lizard";
        }

        //MEMBER METHODS
        public override bool WinsAgainst(Gesture comparisonGestureChoice)
        {
            if (comparisonGestureChoice.gestureName == "paper" || comparisonGestureChoice.gestureName == "spock")
            {
                return true;
            }
            return false;
        }
    }
}
