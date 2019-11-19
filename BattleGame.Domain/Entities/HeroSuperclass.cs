using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class HeroSuperclass : ICharacter
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int ManaPoints { get; set;  }
        public int BaseAttackDamage { get; set; }

        // instance variables
        public IAttack AttackBehaviour;
        public IDefend DefendBehaviour;

        public HeroSuperclass(string name)
        {
            Name = name;
        }

        public int PerformAttack()
        {
            return AttackBehaviour.Attack(BaseAttackDamage);
        }

        public void PerformBlock(int damageRecieved)
        {
            DefendBehaviour.Block(damageRecieved);
        }

    }
}
