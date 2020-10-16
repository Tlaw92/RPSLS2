using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSround2
{
    class ComputerPlayer : Player
    {
        //Variables (Has a)
        public int randomNum;

        //Constructor
        public ComputerPlayer()
        {
            name = "CPU";
        }

        //Methods (Can do)
        public override void ChooseGesture()
        {
            Random rng = new Random();
            randomNum = rng.Next(0, 4);
            chosenGesture = gestures[randomNum];
            Console.WriteLine($"The computer has chosen {chosenGesture}");
        }

    }
}
