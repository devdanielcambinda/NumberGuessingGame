using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Guessing_Game
{
    class Jogada
    {
        
        public int Tries { get;}
        public int Number { get;}
        public string Guesser { get;}
        public string Difficulty { get;}

        public Jogada(string guesser, int number , int tries, string difficulty)
        {
            this.Guesser = guesser;
            this.Number = number;
            this.Tries = tries;
            this.Difficulty = difficulty;
        }
    }
}
