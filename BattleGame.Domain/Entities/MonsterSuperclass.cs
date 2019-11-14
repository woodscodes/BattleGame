using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class MonsterSuperclass
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int BaseAttackDamage { get; set; }

        public IAttack AttackBehaviour;
        public IDefend DefendBehaviour;

        public void PerformAttack()
        {
            AttackBehaviour.Attack();
        }

        public void PerformBlock()
        {
            DefendBehaviour.Block();
        }
    }
}
