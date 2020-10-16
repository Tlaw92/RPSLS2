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

            while(isValid == false)
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
            if(playerOne.chosenGesture == "Rock"  && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }

            if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }
            //////////////////////////////////////////////
            if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }

            if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }
            ////////////////////////////////////////////////////
            if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }

            if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Lizard")

            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }
            //////////////////////////////////////////////
            if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }

            if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }
            //////////////////////////////////////
            if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }

            if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine(playerOne + "Won the round");
                playerOne.score++;
                
            }

            ////////////////////////////////////////////////
            ///////////////////////////////////////////////  

            if (playerTwo.chosenGesture == "Rock" && playerOne.chosenGesture == "Paper")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }

            if (playerTwo.chosenGesture == "Rock" && playerOne.chosenGesture == "Lizard")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }
            //////////////////////////////////////////////
            if (playerTwo.chosenGesture == "Paper" && playerOne.chosenGesture == "Rock")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }

            if (playerTwo.chosenGesture == "Paper" && playerOne.chosenGesture == "Spock")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }
            ////////////////////////////////////////////////////
            if (playerTwo.chosenGesture == "Scissors" && playerOne.chosenGesture == "Paper")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }

            if (playerTwo.chosenGesture == "Scissors" && playerOne.chosenGesture == "Lizard")

            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }
            //////////////////////////////////////////////
            if (playerTwo.chosenGesture == "Lizard" && playerOne.chosenGesture == "Spock")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }

            if (playerTwo.chosenGesture == "Lizard" && playerOne.chosenGesture == "Paper")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }
            //////////////////////////////////////
            if (playerTwo.chosenGesture == "Spock" && playerOne.chosenGesture == "Scissors")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }

            if (playerTwo.chosenGesture == "Spock" && playerOne.chosenGesture == "Rock")
            {
                Console.WriteLine(playerTwo + "Won the round");
                playerTwo.score++;
                Console.Clear();
            }
        }

        public void RunGame() //run choose gesture method until one players score is 2
        {
            //I want to loop over the choose gesture method
            while (playerOne.score < 2 && playerTwo.score < 2 )
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                GestureComparison();
                
            }

            
        }

        public void DecideWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne + "Wins the game");
            }
            if (playerTwo.score == 2)
            {
                Console.WriteLine(playerTwo + "Wins the game");
            }
        }
    }
}
