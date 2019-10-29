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
        public override void SelectPlayerName()
        {
            Console.WriteLine("Please input your name.");
            name = Console.ReadLine();
        }

        public override void SelectGesture()
        {
            Console.WriteLine("Select one of these gestures: 'rock' 'paper' 'scissors' 'lizard' 'spock'");
            string gesture = Console.ReadLine();

            switch (gesture)
            {
                case "rock":
                    gesture = "rock";
                    Console.WriteLine(name + " chose " + gesture);
                    break;
                case "paper":
                    gesture = "paper";
                    Console.WriteLine(name + " chose " + gesture);
                    break;
                case "scissors":
                    gesture = "scissors";
                    Console.WriteLine(name + " chose " + gesture);
                    break;
                case "lizard":
                    gesture = "lizard";
                    Console.WriteLine(name + " chose " + gesture);
                    break;
                case "spock":
                    gesture = "spock";
                    Console.WriteLine(name + " chose " + gesture);
                    break;
                default:
                    SelectGesture();
                    break;
            }
        }
    }
}
