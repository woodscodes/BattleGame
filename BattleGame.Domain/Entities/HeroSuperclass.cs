using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class HeroSuperclass
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }
        public int BaseAttackDamage { get; set; }

        // instance variables
        public IAttack AttackBehaviour;
        public IDefend DefendBehaviour;

        public HeroSuperclass(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            AttackBehaviour.Attack();
        }

        public void Defend()
        {
            DefendBehaviour.Block();
        }

    }
}
