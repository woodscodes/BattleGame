using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class MonsterSuperclass : ICharacter
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int BaseAttackDamage { get; set; }

        public IAttack AttackBehaviour;
        public IDefend DefendBehaviour;

        public int PerformAttack()
        {
            return AttackBehaviour.Attack(BaseAttackDamage);
        }

        public int PerformBlock(int damageRecieved)
        {
            return (int)DefendBehaviour.Block(damageRecieved);
        }

    }
}
