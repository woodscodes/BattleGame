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
        public string Name { get; }
        public int HitPoints { get; set; }
        public int BaseAttackDamage { get; }

        public IAttack AttackBehaviour;
        public IDefend DefendBehaviour;

        public int PerformAttack()
        {
            throw new NotImplementedException();
        }

        public void PerformBlock(int damageRecieved)
        {
            throw new NotImplementedException();
        }
    }
}
