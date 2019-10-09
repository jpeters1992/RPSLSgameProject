using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {

        //MEMBER VARIABLES


        //CONSTRUCTOR


        //MEMBER METHODS
        public void SelectGesture()
        {
            Console.WriteLine("Select one of the gestures: 'rock' 'paper' 'scissors' 'lizard' 'spock'");

            switch (gesture)
            {
                case "rock":
                    Console.WriteLine("You chose " + gesture);
                    break;
                case "paper":
                    Console.WriteLine("You chose " + gesture);
                    break;
                case "scissors":
                    Console.WriteLine("You chose " + gesture);
                    break;
                case "lizard":
                    Console.WriteLine("You chose " + gesture);
                    break;
                case "spock":
                    Console.WriteLine("You chose " + gesture);
                    break;
            }
        }

        public void SomeFunction()
        {
            //code execution 
        }

    }
}
