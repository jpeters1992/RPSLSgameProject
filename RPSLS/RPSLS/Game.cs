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
            //leave empty
        }


        //MEMBER METHODS
        public void RunGame()
        {
            DisplayRules();

            int numberOfPlayers = GetNumberOfPlayers();

            CreatePlayers(numberOfPlayers);
        }

        public void DisplayRules()
        {
            System.Console.WriteLine("Intructions are here");
        }

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("Please enter the number of players.");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void CreatePlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
        }
    }
}

