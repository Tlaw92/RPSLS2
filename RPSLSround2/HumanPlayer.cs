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
        public HumanPlayer()
        {
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }

        //Methods (Can do)
        public override void ChooseGesture()
        {
            Console.WriteLine("Which gesture would you \n" +
                "like to pick this round?");
            DisplayOptions();
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    chosenGesture = gestures[0];
                    break;

                case "2":
                    chosenGesture = gestures[1];
                    break;

                case "3":
                    chosenGesture = gestures[2];
                    break;

                case "4":
                    chosenGesture = gestures[3];
                    break;

                case "5":
                    chosenGesture = gestures[4];
                    break;

                default:
                    Console.WriteLine("Invalid input, please try again");
                    ChooseGesture();
                    break;
            }
        }

    }
}
