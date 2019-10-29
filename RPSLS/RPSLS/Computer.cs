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
        public static List<Gesture> gestureOptions = new List<Gesture>();
        public static Random random = new Random();

        //CONSTRUCTOR
        public Computer()
        {

        }

        //MEMBER METHODS
        public override void SelectPlayerName()
        {
            playerName = "Computer";
        }

        public override void SelectGesture()
        {
            gestureOptions.Add(new Rock());
            gestureOptions.Add(new Paper());
            gestureOptions.Add(new Scissors());
            gestureOptions.Add(new Lizard());
            gestureOptions.Add(new Spock());

            int randomChoice = random.Next(0, gestureOptions.Count());
            playerGesture = gestureOptions[randomChoice];
            Console.WriteLine("Computer chose " + playerGesture);
            Console.Clear();
        } 
    }
}
