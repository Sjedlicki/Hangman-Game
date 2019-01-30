using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class SmartyPants : Player
    {
        public override char Guess()
        {            
            char[] smartAlpabet = "aeioutnsrhldcmfpgwybvkxjqz".ToCharArray();
            char[] oxfordDictionary = "eariotnslcudpmhgbfywkvxzjq".ToCharArray();
            //return smartAlpabet[x++];
            return oxfordDictionary[x++];
        }


    }
}
