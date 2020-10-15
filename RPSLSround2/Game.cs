using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSround2
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

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
            Console.WriteLine("Would you like to Play against a Computer, or play against another player? \n" + "\n" +
                "Type 1 to play against Computer \n" + "\n" +
                "Type 2 to play against your friend. ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    playerOne = new HumanPlayer();
                    playerTwo = new ComputerPlayer();
                    break;

                case "2":
                    playerOne = new HumanPlayer();
                    playerTwo = new HumanPlayer();
                    break;

                default:
                    break;
            }
        }
    }
}
