using System;
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
        public string Difficulty { get; set; }

        public Jogada(string guesser, int number , int tries, string difficulty="0")
        {
            this.Guesser = guesser;
            this.Number = number;
            this.Tries = tries;
            this.Difficulty = difficulty;
        }
    }
}
