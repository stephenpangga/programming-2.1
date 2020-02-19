using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            //myProgram.Start();
            myProgram.StartYahtzee();
            Console.ReadKey();
        }
        //first part of the assignment
        void Start()
        {
            /*
            Dice d1 = new Dice(); // dice 1
            for(int i =0; i<7; i++)
            {
                d1.Throw();
                d1.DisplayValue();
            }
            */

            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            yahtzeeGame.Init();
            yahtzeeGame.Throw(); // throw dices
            yahtzeeGame.DisplayValues(); // display result
            Console.WriteLine();
            yahtzeeGame.Throw();
            yahtzeeGame.DisplayValues();
        }
        //second part of the assignment
        void StartYahtzee()
        {
            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            yahtzeeGame.Init();
            PlayYahtzee(yahtzeeGame); // play the game
        }
        void PlayYahtzee(YahtzeeGame game)
        {
            int nrOfAttempts = 0;
            do
            {
                game.Throw(); // throw all dices 
                game.DisplayValues(); // display the thrown
                nrOfAttempts++;
            } while (!game.Yahtzee());
            Console.WriteLine("Number of attempts needed (Yahtzee): {0}", nrOfAttempts);
        }
    }
}
