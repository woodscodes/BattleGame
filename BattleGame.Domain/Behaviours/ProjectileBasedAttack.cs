using BattleGame.Domain.Contracts;
using BattleGame.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Behaviours
{
    public class ProjectileBasedAttack : IAttack
    {
        IDice dice;

        public ProjectileBasedAttack()
        {
            dice = new TwoSixSideDiceRoll();
        }

        public int Attack(int baseAttackDamage)
        {
            baseAttackDamage = dice.Roll(baseAttackDamage, baseAttackDamage + 10);
            return baseAttackDamage;
        }
    }
}
