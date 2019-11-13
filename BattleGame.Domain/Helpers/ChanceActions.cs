using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Helpers
{
    public class ChanceActions
    {
        private Random _rand;
        private int _rollValue;

        public ChanceActions()
        {
            _rand = new Random();
        }

        public double RollForBlock(int attackDamage)
        {
            _rollValue = _rand.Next(1, 13);

            if (_rollValue == 12)
                return 0;
            else if (_rollValue <= 11 && _rollValue >= 8)
                return attackDamage * (1 - .40);
            else if (_rollValue <= 7 && _rollValue >= 4)
                return attackDamage * (1 - .20);
            else
                return attackDamage * (1 - .10);
        }

        public double RollForAttackDamage(int baseAttackDamage)
        {
            baseAttackDamage = _rand.Next(baseAttackDamage, baseAttackDamage + 1);
            baseAttackDamage += (int)rollForCrit(baseAttackDamage);
            return baseAttackDamage;
        }

        private double rollForCrit(int baseAttackDamage)
        {
            _rollValue = _rand.Next(1, 13);
            if (_rollValue >= 11)
                return baseAttackDamage * (1 + .33);
            return 0.0;
        }
    }
}
