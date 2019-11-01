using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Character : ICharacter, IActions
    {
        public string Name { get; }
        public int HitPoints { get; set; }
        public int BaseAttackDamage { get; }
        private Random _rand;

        public Character(string name, int hitPoints, int baseAttackDamage)
        {
            Name = name;
            HitPoints = hitPoints;
            BaseAttackDamage = baseAttackDamage;
            _rand = new Random();
        }

        public int Attack()
        {
            return _rand.Next(BaseAttackDamage, BaseAttackDamage + 1); // needs to be abstracted into its method / class TODO
            // The character classes should not be responsible for the implmentation of this method, the method is included but the calculations should be 
            // abstracted into something else it violates SRP...
        }

        public void Block()
        {
            // some class here is going to be responsible for the defending
        }

        public void CastSpell()
        {
            // for the future?
        }

        public void UseItem()
        {
            // for the future?
        }
    }
}
