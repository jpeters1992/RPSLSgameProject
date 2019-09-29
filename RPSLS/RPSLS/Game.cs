using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        // member variables (HAS A)

        public Player playerOne;
        public Player playerTwo;
        List<Gestures> gestures;



        // constructor (SPAWNER) - the consturctor is called everytime a new instance of a class is created
        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();
            gestures = new List<Gestures>();

        }



        // member methods (CAN DO)
        public void Use() // main method
        {
            // list in order here what I want to execute in order. this is then called in the Progam.cs
            DisplayRules();
            GetNumberOfPlayers();
            p1.ChooseGesture();
            p2.ChooseGesture();

            p1.gesture();
        }


        public void DisplayRules()
        {
            Console.WriteLine("Two players take turns with Rock-Paper-Scissors-Lizard-Spock");
            Console.WriteLine("Best of 3 determines the winner.");
            Console.WriteLine("Rules:");
            Console.WriteLine("--Scissors cuts Paper--");
            Console.WriteLine("--Scissors decapitates Lizard--");
            Console.WriteLine("--Paper covers Rock--");
            Console.WriteLine("--Paper disproves Spock--");
            Console.WriteLine("--Rock crushes Lizard--");
            Console.WriteLine("--Rock crushes Scissors--");
            Console.WriteLine("--Lizard eats Paper--");
            Console.WriteLine("--Lizard poisons Spock--");
            Console.WriteLine("--Spock smashes Scissors--");
            Console.WriteLine("--Spock vaporizes Rock--");
        }

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void createPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                p1 = new Human();
                p2 = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                p1 = new Human();
                p2 = new Human();
            }
        }
    }
}
