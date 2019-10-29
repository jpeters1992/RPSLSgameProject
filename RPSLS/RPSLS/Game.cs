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
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public string roundChoice = "";

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
            int numberOfPlayers = GetNumberOfPlayers();

            CreatePlayers(numberOfPlayers);

            NewLine();
            playerOne.SelectPlayerName();
            NewLine();
            playerTwo.SelectPlayerName();

            NewLine();
            PlayRounds();
        }

        public void DisplayRules()
        {
            System.Console.WriteLine("--Select a gesture - best of 3 rounds wins.-- \n--Rock crushes Scissors-- \n--Scissors cuts Paper-- \n--Paper covers Rock-- \n--Rock crushes Lizard-- \n--Lizard poisons Spock-- \n--Spock smashes Scissors-- \n--Scissors decapitates Lizard-- \n--Lizard eats Paper-- \n--Paper disproves Spock-- \n--Spock vaporizes Rock--");
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
            else
            {
                Console.WriteLine("Invalid input: enter '1' or '2'");
            }
        }

        public void PlayRounds()
        {
            do
            {
                playerOne.SelectGesture();
                playerTwo.SelectGesture();
                GestureLogic();
                //DisplayGameWinner();

            }
            while (playerOneScore < 2 && playerTwoScore < 2);

        }

        //public void DisplayGameWinner()
        //{
        //    if (playerOne.gesture == playerTwo.gesture)
        //    {
        //        SelectGesture();
        //    }
        //    else if (playerOne.gesture == roundChoice)
        //    {
        //        playerOneScore++;
        //        Console.WriteLine(playerOne.name + " has a score of " + playerOneScore);
        //        if (playerOneScore == 2)
        //            Console.WriteLine(playerOne.name + " WINS!");
        //    }
        //    else
        //    {
        //        playerTwoScore++;
        //        Console.WriteLine(playerTwo.name + " has a score of " + playerTwoScore);
        //        if (playerTwoScore == 2)
        //            Console.WriteLine(playerTwo.name + " WINS!");
        //    }
        //}

        public void GestureLogic()
        {
            if (playerOne.playerGesture == playerTwo.playerGesture)
            {
                roundChoice = "tie";
                Console.WriteLine("Players tied! Shoot again");
            }
            else if (playerOne.playerGesture == "rock" && playerTwo.playerGesture == "scissors")
            {
                roundChoice = "rock";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "rock" && playerTwo.playerGesture == "lizard")
            {
                roundChoice = "rock";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "rock" && playerTwo.playerGesture == "spock")
            {
                roundChoice = "spock";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "rock" && playerTwo.playerGesture == "paper")
            {
                roundChoice = "paper";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "paper" && playerTwo.playerGesture == "rock")
            {
                roundChoice = "paper";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "paper" && playerTwo.playerGesture == "spock")
            {
                roundChoice = "paper";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "paper" && playerTwo.playerGesture == "scissors")
            {
                roundChoice = "scissors";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "paper" && playerTwo.playerGesture == "lizard")
            {
                roundChoice = "lizard";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "scissors" && playerTwo.playerGesture == "paper")
            {
                roundChoice = "scissors";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "scissors" && playerTwo.playerGesture == "lizard")
            {
                roundChoice = "scissors";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "scissors" && playerTwo.playerGesture == "rock")
            {
                roundChoice = "rock";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "scissors" && playerTwo.playerGesture == "spock")
            {
                roundChoice = "spock";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "lizard" && playerTwo.playerGesture == "paper")
            {
                roundChoice = "lizard";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "lizard" && playerTwo.playerGesture == "spock")
            {
                roundChoice = "lizard";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "lizard" && playerTwo.playerGesture == "rock")
            {
                roundChoice = "rock";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "lizard" && playerTwo.playerGesture == "scissors")
            {
                roundChoice = "scissors";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "spock" && playerTwo.playerGesture == "scissors")
            {
                roundChoice = "spock";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "spock" && playerTwo.playerGesture == "rock")
            {
                roundChoice = "spock";
                playerOne.playerScore++;
            }
            else if (playerOne.playerGesture == "spock" && playerTwo.playerGesture == "lizard")
            {
                roundChoice = "lizard";
                playerTwo.playerScore++;
            }
            else if (playerOne.playerGesture == "spock" && playerTwo.playerGesture == "paper")
            {
                roundChoice = "paper";
                playerTwo.playerScore++;
            }
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }
    }
}

