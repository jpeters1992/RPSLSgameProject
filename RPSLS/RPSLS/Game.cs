using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //MEMBER VARIABLES
        public Player playerOne;
        public Player playerTwo;

        //CONSTRUCTOR
        public Game()
        {

        }

        //MEMBER METHODS
        public void RunGame()
        {
            NewLine();
            DisplayRules();
            NewLine();
            GetNumberOfPlayers();
            NewLine();
            PlayRounds();
        }

        public void DisplayRules()
        {
            System.Console.WriteLine("--Select a gesture - best of 3 rounds wins.-- \n--Rock crushes Scissors-- \n--Scissors cuts Paper-- \n--Paper covers Rock-- \n--Rock crushes Lizard-- \n--Lizard poisons Spock-- \n--Spock smashes Scissors-- \n--Scissors decapitates Lizard-- \n--Lizard eats Paper-- \n--Paper disproves Spock-- \n--Spock vaporizes Rock--");
        }

        public void GetNumberOfPlayers()
        {
            Console.WriteLine("Please enter the number of players: 1 or 2");
            string choice = Console.ReadLine();
           
            if (choice == "1")
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (choice == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                Console.WriteLine("Invalid input: enter '1' or '2'");
            }
        }

        public void PlayRounds()
        {
            playerOne.SelectGesture();
            playerTwo.SelectGesture();
            GestureLogic();
            Console.ReadLine();
        }

       
        public void GestureLogic()
        {
            //code out
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }
    }
}

