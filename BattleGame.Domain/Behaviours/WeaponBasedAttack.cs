using BattleGame.Domain.Contracts;
using BattleGame.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Behaviours
{
    public class WeaponBasedAttack : IAttack
    {
        IDice dice;

        public WeaponBasedAttack()
        {
            dice = new TwoSixSideDiceRoll();
        }

        public int Attack(int baseAttackDamage)
        {
            baseAttackDamage = dice.Roll(baseAttackDamage, baseAttackDamage + 5);
            baseAttackDamage += (int)CriticalStrike(baseAttackDamage);
            return baseAttackDamage;
        }
        
        private double CriticalStrike(int baseAttackDamage)
        {
            var roll = dice.Roll();

            if (roll >= 11)
                return baseAttackDamage * (1 + .33);
            return 0.0;
        }
    }
}
