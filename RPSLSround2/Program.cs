﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSround2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game1 = new Game();
            game1.WelcomeAndRules();
            game1.ChooseGameType();
            game1.GestureComparison();
            game1.RunGame();
            game1.DecideWinner();
        }
    }
}
