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
            if (playerOne.gesture == playerTwo.gesture)
            {
                roundChoice = "tie";
                Console.WriteLine("Players tied! Shoot again");
            }
            else if (playerOne.gesture == "rock" && playerTwo.gesture == "scissors")
            {
                roundChoice = "rock";
                playerOne.score++;
            }
            else if (playerOne.gesture == "rock" && playerTwo.gesture == "lizard")
            {
                roundChoice = "rock";
                playerOne.score++;
            }
            else if (playerOne.gesture == "rock" && playerTwo.gesture == "spock")
            {
                roundChoice = "spock";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "rock" && playerTwo.gesture == "paper")
            {
                roundChoice = "paper";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "paper" && playerTwo.gesture == "rock")
            {
                roundChoice = "paper";
                playerOne.score++;
            }
            else if (playerOne.gesture == "paper" && playerTwo.gesture == "spock")
            {
                roundChoice = "paper";
                playerOne.score++;
            }
            else if (playerOne.gesture == "paper" && playerTwo.gesture == "scissors")
            {
                roundChoice = "scissors";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "paper" && playerTwo.gesture == "lizard")
            {
                roundChoice = "lizard";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "scissors" && playerTwo.gesture == "paper")
            {
                roundChoice = "scissors";
                playerOne.score++;
            }
            else if (playerOne.gesture == "scissors" && playerTwo.gesture == "lizard")
            {
                roundChoice = "scissors";
                playerOne.score++;
            }
            else if (playerOne.gesture == "scissors" && playerTwo.gesture == "rock")
            {
                roundChoice = "rock";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "scissors" && playerTwo.gesture == "spock")
            {
                roundChoice = "spock";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "lizard" && playerTwo.gesture == "paper")
            {
                roundChoice = "lizard";
                playerOne.score++;
            }
            else if (playerOne.gesture == "lizard" && playerTwo.gesture == "spock")
            {
                roundChoice = "lizard";
                playerOne.score++;
            }
            else if (playerOne.gesture == "lizard" && playerTwo.gesture == "rock")
            {
                roundChoice = "rock";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "lizard" && playerTwo.gesture == "scissors")
            {
                roundChoice = "scissors";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "spock" && playerTwo.gesture == "scissors")
            {
                roundChoice = "spock";
                playerOne.score++;
            }
            else if (playerOne.gesture == "spock" && playerTwo.gesture == "rock")
            {
                roundChoice = "spock";
                playerOne.score++;
            }
            else if (playerOne.gesture == "spock" && playerTwo.gesture == "lizard")
            {
                roundChoice = "lizard";
                playerTwo.score++;
            }
            else if (playerOne.gesture == "spock" && playerTwo.gesture == "paper")
            {
                roundChoice = "paper";
                playerTwo.score++;
            }
        }

        public static void NewLine()
        {
            Console.WriteLine("");
        }
    }
}

