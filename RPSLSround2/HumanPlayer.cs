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
        
    }
}
