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
        }

        public bool Yahtzee()
        {
            return true;
        }
    }
}
