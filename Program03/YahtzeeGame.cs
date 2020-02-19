using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program03
{
    class YahtzeeGame
    {
        Dice[] dice = new Dice[5];

        public void Init()
        {
            for(int i = 0; i<dice.Length; i++)
            {
                dice[i] = new Dice();
            }
        }

        public void Throw()
        {
            for(int i =0; i<dice.Length; i++)
            {
                dice[i].Throw();
            }
        }

        public void DisplayValues()
        {
            for(int i=0; i<dice.Length; i++)
            {
                dice[i].DisplayValue();
            }
            Console.WriteLine(); //spacing.
        }

        public bool Yahtzee()
        {
            for (int i = 0; i <dice.Length; i++)
            {
                if(dice[0].value != dice[i].value)
                {
                    //if the 1st dice is not the same as the rest, a checker for yahtzee combination
                    //return false.
                    return false;
                }
            }
            return true;
        }

        public bool ThreeOfAkind()
        {
            //i dont really know how to do this.. also for 4 of a kind.
            return true;
        }
    }
}
