using System;
using System.Collections.Generic;
using System.IO;
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

            int wins = 0;
            double sumABC = 0;
            double sumRandom = 0;
            double sumSmarty = 0;
            double averageABC = 0;
            double averageRandom = 0;
            double averageSmarty = 0;
            double sumHuman = 0;
            double averageHuman = 0;
            List<int> tries = new List<int>();

            // BRUTEFORCE PLAYER
            wins = 1;
            do
            {
                p1.Reset();
                HangmanGame hg = new HangmanGame(p1);
                tries.Add(hg.tries);
                sumABC += hg.tries;
                wins++;
            } while (wins <= 1000);
            averageABC = sumABC / wins;

            // RANDOM GUESS PLAYER
            wins = 1;
            do
            {
                p2.Reset();
                HangmanGame hg = new HangmanGame(p2);
                sumRandom += hg.tries;
                wins++;
            } while (wins <= 1000);
            averageRandom = sumRandom / wins;

            // SMART PLAYER
            wins = 1;
            do
            {
                p3.Reset();
                HangmanGame hg = new HangmanGame(p3);
                sumSmarty += hg.tries;
                wins++;
            } while (wins <= 1000);
            averageSmarty = sumSmarty / wins;

            //// HUMAN PLAYER
            //wins = 1;
            //do
            //{
            //    p4.Reset();
            //    HangmanGame hg = new HangmanGame(p4);
            //    sumHuman += hg.tries;
            //    wins++;
            //} while (wins <= 10);
            //averageHuman = sumHuman / 10;

            Console.WriteLine("ABC tries: " + averageABC);
            Console.WriteLine("Random tries: " + averageRandom);
            Console.WriteLine("Smarty tries: " + averageSmarty);
            Console.WriteLine("Human tries: " + averageHuman);

            if (averageSmarty < averageABC && averageSmarty < averageRandom && averageSmarty < averageHuman)
            {
                Console.WriteLine($"SmartyPants is the smartest person around!");
            }
            else if (averageABC < averageRandom && averageABC < averageSmarty && averageABC < averageHuman)
            {
                Console.WriteLine($"BruteForce Wins!");
            }
            else if (averageRandom < averageSmarty && averageRandom < averageABC && averageRandom < averageHuman)
            {
                Console.WriteLine("Random Wins!");
            }
            else
            {
                Console.WriteLine("YOU ARE THE SMARTEST AROUND!!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
