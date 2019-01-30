using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
   
    abstract class Player
    {
        public int x = 0;
        public List<char> alphabet = new List<char>() {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        public abstract char Guess();
        public int Reset()
        {
            return x = 0;
        }
    }

}
