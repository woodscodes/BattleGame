using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Character
    {
        public string Name { get; }
        public int HitPoints { get; }
        public int BaseAttackDamage { get; }

        public Character(string name, int hitPoints, int baseAttackDamage)
        {
            Name = name;
            HitPoints = hitPoints;
            BaseAttackDamage = baseAttackDamage;
        }
    }
}
