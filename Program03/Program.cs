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
            myProgram.Start();
            Console.ReadKey();
        }

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
    }
}
