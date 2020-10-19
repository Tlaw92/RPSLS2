using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSround2
{
    class HumanPlayer : Player
    {
        //Variables (Has a)
        
        //Constructor
        public HumanPlayer(int playerNumber)
        {
            Console.Clear();
            Console.WriteLine($" Player {playerNumber} Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"\nPress Enter to begin the first round!");
        }

        //Methods (Can do)
        public override void ChooseGesture()
        {
            Console.WriteLine($"{name} its is your turn to pick a gesture");
            Console.WriteLine("\nWhich gesture would you like to choose this round?\n");
            DisplayOptions();
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.Clear(); Console.WriteLine("\n");
                    chosenGesture = gestures[0];
                    break;

                case "2":
                    Console.Clear(); Console.WriteLine("\n");
                    chosenGesture = gestures[1];
                    break;

                case "3":
                    Console.Clear(); Console.WriteLine("\n");
                    chosenGesture = gestures[2];
                    break;

                case "4":
                    Console.Clear(); Console.WriteLine("\n");
                    chosenGesture = gestures[3];
                    break;

                case "5":
                    Console.Clear(); Console.WriteLine("\n");
                    chosenGesture = gestures[4];
                    break;

                default:
                    Console.WriteLine("Invalid input, please try again");
                    Console.ReadLine();
                    Console.Clear();
                    ChooseGesture();
                    break;
            }
        }

    }
}
