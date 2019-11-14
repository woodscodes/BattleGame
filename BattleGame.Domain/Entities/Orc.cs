using BattleGame.Domain.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Orc : MonsterSuperclass
    {
        public Orc()
        {
            Name = "Orcy";
            HitPoints = 150;
            BaseAttackDamage = 35;

            AttackBehaviour = new WeaponBasedAttack();
            DefendBehaviour = new ArmouredBlock();
        }
    }
}
