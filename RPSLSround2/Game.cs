using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSround2
{
    class Game
    {
        //variables
        public Player playerOne;
        public Player playerTwo;

        //constructor
        public Game()
        {


        }


        //methods

        public void WelcomeAndRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!! \n" +
                "\n" +
                "");

            Console.WriteLine("Here's how the game works: \n" +
                "Rock crushes Scissors \n" +
                "Scissors cuts Paper \n" +
                "Paper covers Rock \n" +
                "Rock crushes Lizard \n" +
                "Lizard poisons Spock \n" +
                "Spock smashes Scissors \n" +
                "Scissors decapitates Lizard \n" +
                "Lizard eats Paper \n" +
                "Paper disproves Spock \n" +
                "And lastly, \n" +
                "Spock vaporizes Rock \n" +
                "\n" +
                "\n" +
                "First Player to win two rounds wins the game!\n" +
                "Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public void ChooseGameType()
        {
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine("Would you like to Play against a Computer, or play against another player? \n" + "\n" +
               "Type 1 to play against Computer \n" + "\n" +
               "Type 2 to play against your friend. ");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        playerOne = new HumanPlayer();
                        playerTwo = new ComputerPlayer();
                        isValid = true;
                        break;

                    case "2":
                        playerOne = new HumanPlayer();
                        playerTwo = new HumanPlayer();
                        isValid = true;
                        break;

                    default:
                        Console.WriteLine("Invalid input, please try again");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }

        }

        public void GestureComparison()
        {
            ///////// Player One Winning //////////
            ///Rock
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
            if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerOne.name + " Chose Rock \n" +
                   playerTwo.name + " Chose Scissors \n" +
                   playerOne.name + " Won the round");
                playerOne.score++;
            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerOne.name + " Chose Rock \n" +
                   playerTwo.name + " Chose Lizard \n" +
                   playerOne.name + " Won the round");
                playerOne.score++;

            }
            //////////////////////////////////////////////
            ///Paper
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerOne.name + " Chose Paper \n" +
                   playerTwo.name + " Chose Rock \n" +
                   playerOne.name + " Won the round");
                playerOne.score++;

            }

            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerOne.name + "Chose Paper \n" +
                   playerTwo.name + " Chose Spock \n" +
                   playerOne.name + " Won the round");
                playerOne.score++;

            }
            ///////////////////////////////////////////////
            ///Scissors
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerOne.name + " Chose Scissors \n" +
                   playerTwo.name + " Chose Paper \n" +
                   playerOne.name + " Won the round");
                playerOne.score++;

            }

            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Lizard")

            {
                Console.WriteLine(playerOne.name + " Chose Scissors \n" +
                   playerTwo.name + " Chose Lizard \n" +
                   playerOne.name + " Won the round");
                playerOne.score++;

            }
            //////////////////////////////////////////////
            ///Lizard
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerOne.name + " Chose Lizard \n" +
                    playerTwo.name + " Chose Spock \n" +
                    playerOne.name + " Won the round");
                playerOne.score++;

            }

            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerOne.name + " Chose Lizard \n" +
                  playerTwo.name + " Chose Paper \n" +
                  playerOne.name + " Won the round");
                playerOne.score++;

            }
            //////////////////////////////////////
            ///Spock
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerOne.name + " Chose Spock \n" +
                  playerTwo.name + " Chose Scissors \n" +
                  playerOne.name + " Won the round");
                playerOne.score++;

            }

            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerOne.name + " Chose Spock \n" +
                  playerTwo.name + " Chose Rock \n" +
                  playerOne.name + " Won the round");
                playerOne.score++;

            }

            ////////////////////////////////////////////////
            ///Player Two Winning///
            ///////////////////////////////////////////////  
            //Rock
            if (playerTwo.chosenGesture == "Rock" && playerOne.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerTwo.name + " Chose Rock \n" +
                  playerOne.name + " Chose Scissors \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }

            else if (playerTwo.chosenGesture == "Rock" && playerOne.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerTwo.name + " Chose Rock \n" +
                  playerOne.name + " Chose Lizard \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }
            //////////////////////////////////////////////
            /////Paper
            else if (playerTwo.chosenGesture == "Paper" && playerOne.chosenGesture == "Rock")
            {
                Console.WriteLine(playerTwo.name + " Chose Paper \n" +
                  playerOne.name + " Chose Rock \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }

            else if (playerTwo.chosenGesture == "Paper" && playerOne.chosenGesture == "Spock")
            {
                Console.WriteLine(playerTwo.name + " Chose Paper \n" +
                  playerOne.name + " Chose Spock \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }
            ////////////////////////////////////////////////////
            ///Scissors
            else if (playerTwo.chosenGesture == "Scissors" && playerOne.chosenGesture == "Paper")
            {
                Console.WriteLine(playerTwo.name + " Chose Scissors \n" +
                  playerOne.name + " Chose Paper \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }

            else if (playerTwo.chosenGesture == "Scissors" && playerOne.chosenGesture == "Lizard")

            {
                Console.WriteLine(playerTwo.name + " Chose Scissors \n" +
                  playerOne.name + " Chose Lizard \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }
            //////////////////////////////////////////////
            ///Lizard
            else if (playerTwo.chosenGesture == "Lizard" && playerOne.chosenGesture == "Spock")
            {
                Console.WriteLine(playerTwo.name + " Chose Lizard \n" +
                  playerOne.name + " Chose Spock \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }

            else if (playerTwo.chosenGesture == "Lizard" && playerOne.chosenGesture == "Paper")
            {
                Console.WriteLine(playerTwo.name + " Chose Lizard \n" +
                  playerOne.name + " Chose Paper \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }
            //////////////////////////////////////
            ///Spock
            else if (playerTwo.chosenGesture == "Spock" && playerOne.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerTwo.name + " Chose Spock \n" +
                  playerOne.name + " Chose Scissors \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }

            else if (playerTwo.chosenGesture == "Spock" && playerOne.chosenGesture == "Rock")
            {
                Console.WriteLine(playerTwo.name + " Chose Spock \n" +
                  playerOne.name + " Chose Rock \n" +
                  playerTwo.name + " Won the round");
                playerTwo.score++;
            }
            else if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine($"{playerOne.name} and {playerTwo.name} Both chose {playerOne.chosenGesture}.\n" +
                    $"It was a Tie");
            }
        }

        public void RunGame() //run choose gesture method until one players score is 2
        {
            //I want to loop over the choose gesture method
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                GestureComparison();
                Console.WriteLine($"{playerOne.name} score is {playerOne.score} \n{playerTwo.name} score is {playerTwo.score}");
                Console.ReadLine();
                Console.Clear();

            }
        }

        public void DecideWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} wins the game");
                Console.ReadLine();
            }
            if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} wins the game");
                Console.ReadLine();
            }
        }
        public void RunMain()
        {
            WelcomeAndRules();
            ChooseGameType();
            RunGame();
            DecideWinner();
        }
    }
}
