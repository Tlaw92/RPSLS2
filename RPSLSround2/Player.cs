using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSround2
{
    abstract class Player
    {
        //Variables (Has a)
        public string name;
        public int score;
        public string chosenGesture;
        public List<string> gestures;

        //Constructor
        public Player()
        {
         
            score = 0;

            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        //Methods (Can do)
        public abstract void ChooseGesture();

        public void DisplayOptions()
        {
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"Press {i+1} for {gestures[i]}");
            }
        }
        

    }
}
