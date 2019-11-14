using BattleGame.Domain.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Warrior : HeroSuperclass
    {
        public Warrior(string name) : base(name)
        {
            Name = name;
            HitPoints = 125;
            ManaPoints = 50;
            BaseAttackDamage = 30;

            AttackBehaviour = new WeaponBasedAttack();
            DefendBehaviour = new ArmouredBlock();
        }
    }
}
