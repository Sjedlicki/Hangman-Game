using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class RandomPlayer : Player
    {
        private int index;
        private Random r = new Random();

        public override char Guess()
        {
            index = r.Next(0, guessedLetters.Count);
            char output = guessedLetters[index];
            guessedLetters.Remove(output);
            return output;
        }
    }
}
