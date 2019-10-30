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
        public int bestOfXrounds;

        //CONSTRUCTOR
        public Game()
        {

        }

        //MEMBER METHODS
        public void RunGame()
        {
            NewLine();
            DisplayRules();

            GetNumberOfPlayers();
            ChooseBestOfXrounds();
            PlayRounds();
        }

        public static void NewLine()
        {
            //inserts blank line for spacing
            Console.WriteLine("");
        }

        public void DisplayRules()
        {
            System.Console.WriteLine("Select a gesture - best of X rounds wins: \n--Rock crushes Scissors-- \n--Scissors cuts Paper-- \n--Paper covers Rock-- \n--Rock crushes Lizard-- \n--Lizard poisons Spock-- \n--Spock smashes Scissors-- \n--Scissors decapitates Lizard-- \n--Lizard eats Paper-- \n--Paper disproves Spock-- \n--Spock vaporizes Rock--");
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

        public void ChooseBestOfXrounds()
        {
            try
            {
                bestOfXrounds = Convert.ToInt32(UserInterface.RetrieveUserInput("How many rounds do you want? Best of X (odd numbers only)"));
            }
            catch (Exception)
            {
                Console.WriteLine("Please select an integer");
            }

            if (bestOfXrounds >= 3 && bestOfXrounds % 2 == 1)
            {
                return;
            }
            else
            {
                Console.WriteLine("Please enter a number greater than or equal to 3");
                ChooseBestOfXrounds();
            }
        }

        public void PlayRounds()
        {
            playerOne.SelectGesture();
            playerTwo.SelectGesture();
            GestureLogic();
            AddScoreToWinner();
            CheckRoundWinnerScore();
            Console.ReadLine();
        }
// -----------------------------------------------------------------------------------------------
       
        public bool GestureLogic()
        {
            playerOne.isWinner = false;
            playerTwo.isWinner = false;
            if (playerOne.playerGesture.WinsAgainst(playerTwo.playerGesture))
            {
                return playerOne.isWinner = true;
            }
            else if (playerTwo.playerGesture.WinsAgainst(playerOne.playerGesture))
            {
                return playerTwo.isWinner = true;
            }
            else if ((!playerOne.playerGesture.WinsAgainst(playerTwo.playerGesture) && !playerTwo.playerGesture.WinsAgainst(playerOne.playerGesture)))
            {
                Console.WriteLine("Tied! Go again!");
            }
            return false;
        }

        public void AddScoreToWinner()
        {
            if (playerOne.isWinner)
            {
                playerOne.playerScore++;
            }
            else if (playerTwo.isWinner)
            {
                playerTwo.playerScore++;
            }
            return;
        }

        public void CheckRoundWinnerScore()
        {
            if (playerOne.playerScore == (bestOfXrounds + 1) / 2)
            {
                Console.WriteLine(playerOne.playerName + " has won the match!");
            }
            else if (playerTwo.playerScore == (bestOfXrounds + 1) / 2)
            {
                Console.WriteLine(playerTwo.playerName + " has won the match!");
            }
            Console.WriteLine("Current score: \n" + playerOne.playerName + " " + playerOne.playerScore + " - " + playerTwo.playerName + " " + playerTwo.playerScore);
            while (playerOne.playerScore != (bestOfXrounds + 1) / 2 && playerTwo.playerScore != (bestOfXrounds + 1) / 2)
            {
                PlayRounds();
                Console.ReadLine();
            }
        }
    }
}

