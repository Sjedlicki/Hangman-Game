using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class Program
    {
        static void Main(string[] args)
        {
            // POLYMORPHISM!!!
            Player p1 = new ABCplayer();            
            Player p2 = new RandomPlayer();
            Player p3 = new SmartyPants();
            Player p4 = new HumanPlayer();

            List<Player> x = new List<Player>();
            x.Add(p1);
            x.Add(p2);
            x.Add(p3);
            //x.Add(p4);

            double sumABC = 0;
            double sumRandom = 0;
            double sumSmarty = 0;
            double averageABC = 0;
            double averageRandom = 0;
            double averageSmarty = 0;
            List<int> tries = new List<int>();

            int wins = 1;
                do
                {
                    p1.Reset();
                    HangmanGame hg = new HangmanGame(p1);
                    tries.Add(hg.tries);
                    sumABC += hg.tries;
                    wins++;
                } while (wins <= 10);
            averageABC = sumABC / 10;

            wins = 1;
            do
            {
                p2.Reset();
                HangmanGame hg = new HangmanGame(p2);
                sumRandom += hg.tries;
                wins++;
            } while (wins <= 10);
            averageRandom = sumRandom / 10;

            wins = 1;
            do
            {
                p3.Reset();
                HangmanGame hg = new HangmanGame(p3);
                sumSmarty += hg.tries;
                wins++;
            } while (wins <= 10);
            averageSmarty = sumSmarty / 10;

            Console.WriteLine("ABC tries: " + averageABC);
            Console.WriteLine("Random tries: " + averageRandom);
            Console.WriteLine("Smarty tries: " + averageSmarty);

            if(averageSmarty < averageABC && averageSmarty < averageRandom)
            {
                Console.WriteLine($"SmartyPants is the smartest person around!");
            }
            else if (averageABC < averageRandom && averageABC < averageSmarty)
            {
                Console.WriteLine($"BruteForce wins!");
            }
            else
            {
                Console.WriteLine($"Random wins!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
