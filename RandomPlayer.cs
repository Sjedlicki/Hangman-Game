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
            bool run = true;
            while (run == true)
            {
                index = r.Next(0, alphabet.Count);
                if (guessedLetters.Contains(alphabet[index]))
                {
                    run = true;
                }
                else
                {
                    guessedLetters.Add(alphabet[index]);
                    run = false;
                }
            }
            Console.WriteLine(alphabet[index]);
            return alphabet[index];
        }
    }
}
