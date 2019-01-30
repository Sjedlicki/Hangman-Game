using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class RandomPlayer : Player
    {
        public override char Guess()
        {
            Random r = new Random();
            int index = r.Next(0, alphabet.Count);
            return alphabet[index];
        }
    }
}
