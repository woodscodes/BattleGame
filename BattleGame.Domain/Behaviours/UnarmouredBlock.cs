using BattleGame.Domain.Contracts;
using BattleGame.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Behaviours
{
    public class UnarmouredBlock : IDefend
    {
        IDice dice;

        public UnarmouredBlock()
        {
            dice = new TwoSixSideDiceRoll();
        }

        public double Block(int damageReceived)
        {
            var roll = dice.Roll();

            if (roll == 12)
                return 0;
            else if (roll <= 11 && roll >= 8)
                return damageReceived * (1 - .30);
            else if (roll <= 7 && roll >= 4)
                return damageReceived * (1 - .10);
            else
                return damageReceived * (1 - .05);
        }
    }
}
