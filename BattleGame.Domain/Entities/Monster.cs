using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Monster : Character
    {
        // future idea, hitPoints and baseAttackDamage to be decided by a list of monster types ? (Factory pattern practice and SRP stuff)
        public Monster(string name, int hitPoints, int baseAttackDamage) : base(name, hitPoints, baseAttackDamage)
        {

        }
    }
}
