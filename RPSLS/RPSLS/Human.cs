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
        public string gestureChoice;

        //CONSTRUCTOR
        public Human()
        {

        }


        //MEMBER METHODS
        public override void SelectPlayerName()
        {
            playerName = UserInterface.RetrieveUserInput("Choose player name.");
            Console.WriteLine("Hello, " + playerName);
        }

        public override void SelectGesture()
        {
            gestureChoice = UserInterface.RetrieveUserInput("Select one of these gestures: 'rock' 'paper' 'scissors' 'lizard' 'spock'");
            switch (gestureChoice)
            {
                case "rock":
                    playerGesture = new Rock();
                    break;
                case "paper":
                    playerGesture = new Paper();
                    break;
                case "scissors":
                    playerGesture = new Scissors();;
                    break;
                case "lizard":
                    playerGesture = new Lizard();
                    break;
                case "spock":
                    playerGesture = new Spock();
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    SelectGesture();
                    break;
            }
            Console.Clear();
        }
    }
}
