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
            DisplayRules(); 

            int numberOfPlayers = GetNumberOfPlayers(); 

            CreatePlayers(numberOfPlayers);

            playerOne.SelectPlayerName();
            playerTwo.SelectPlayerName();

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.SelectGesture();
                playerTwo.SelectGesture();

                if (playerOne.gesture == playerTwo.gesture)
                {
                    Console.WriteLine("Players tied! Shoot again");
                }
                else if ((playerOne.gesture == "rock" && playerTwo.gesture == "scissors") || (playerOne.gesture == "rock" && playerTwo.gesture == "lizard"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "scissors" && playerTwo.gesture == "paper") || (playerOne.gesture == "scissor" && playerTwo.gesture == "lizard"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "paper" && playerTwo.gesture == "rock") || (playerOne.gesture == "paper" && playerTwo.gesture == "spock"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "lizard" && playerTwo.gesture == "spock") || (playerOne.gesture == "lizard" && playerTwo.gesture == "paper"))
                {
                    playerOne.score++;
                }
                else if ((playerOne.gesture == "spock" && playerTwo.gesture == "scissors") || (playerOne.gesture == "spock" && playerTwo.gesture == "rock"))
                {
                    playerOne.score++;
                }
                else
                {
                    playerTwo.score++;
                }
                DisplayCurrentScore();
            }
            DisplayGameWinner();
        }

        public void DisplayRules()
        {
            System.Console.WriteLine("Intructions here");
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
        public void DisplayCurrentScore()
        {
            Console.WriteLine("Current score: " + playerOne.name + ":" + playerOne.score + " " + playerTwo.name + ":" + playerTwo.score);
        }
        public void DisplayGameWinner()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine(playerOne.name + " won the game!");
            }
            else
            {
                Console.WriteLine(playerTwo.name + " won the game!");
            }
        }
    }
}

