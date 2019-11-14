using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Monster : Character
    {
        public Monster(string name, int hitPoints, int baseAttackDamage) : base(name, hitPoints, baseAttackDamage) { }
    }
}
