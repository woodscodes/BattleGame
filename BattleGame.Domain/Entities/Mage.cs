using BattleGame.Domain.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Mage : HeroSuperclass
    {
        public Mage(string name) : base(name)
        {
            Name = name;
            HitPoints = 100;
            ManaPoints = 125;
            BaseAttackDamage = 40;

            AttackBehaviour = new ProjectileBasedAttack();
            DefendBehaviour = new UnarmouredBlock();
        }
    }
}
