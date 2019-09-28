using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // member variables (HAS A)

        public Player playerOne;
        public Player playerTwo;



        // constructor (SPAWNER) - the consturctor is called everytime a new instance of a class is created
        public Game()
        {
            playerOne = new Player();
            playerTwo = new Player();

        }



        // member methods (CAN DO)
        public void RunGame() //master method
        {
            DisplayRules();

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
    }
}
