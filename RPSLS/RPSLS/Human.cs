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
        public override void SelectGesture()
        {
            Console.WriteLine("Select one of these gestures: 'rock' 'paper' 'scissors' 'lizard' 'spock'");
            string gesture = Console.ReadLine();

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

        public override void SelectPlayerName()
        {
            Console.WriteLine("Please input your name.");
            name = Console.ReadLine();
        }

    }
}
