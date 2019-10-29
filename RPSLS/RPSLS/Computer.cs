using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        //MEMBER VARIABLES
        public Random rng;

        //CONSTRUCTOR
        public Computer()
        {
            rng = new Random();
        }

        //MEMBER METHODS
        public override void SelectPlayerName()
        {
            name = "Computer";
        }

        public override void SelectGesture()
        {
            int gesture = rng.Next(0, gestures.Count);
            this.gesture = gestures[gesture];
            Console.WriteLine("Computer chose " + gestures[gesture]);
        } 

    
    }
}
