using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Hero : Character
    {
        public Hero(string name, int hitPoints, int manaPoints, int baseAttackDamage) : base(name, hitPoints, manaPoints, baseAttackDamage)
        {
            ManaPoints = manaPoints;
        }        
    }
}
