﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Guessing_Game
{
    class Jogada
    {
        
        public int Tries { get; private set;}
        public int Number { get; private set;}
        public string Guesser { get; private set;}

        public Jogada(string guesser, int number , int tries)
        {
            this.Guesser = guesser;
            this.Number = number;
            this.Tries = tries;
        }
    }
}
