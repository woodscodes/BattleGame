using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Helpers
{
    class TwoSixSideDiceRoll : IDice
    {
        // here as in popular fantasy chance games we can implement many different types of dice, here I'm taking it easy by just having one class, but our interface
        // allows us to have more types; 2 x 6 side dice roll, etc.

        private Random _rand;

        public TwoSixSideDiceRoll()
        {
            _rand = new Random();
        }

        public int Roll()
        {
            return _rand.Next(1, 13);
        }

        public int Roll(int baseAttackDamage, int baseAttackDamageUpperRange)
        {
            return _rand.Next(baseAttackDamage, baseAttackDamageUpperRange);
        }
    }
}
