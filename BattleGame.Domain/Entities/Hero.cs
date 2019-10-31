using BattleGame.Domain.Contracts;
using BattleGame.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Entities
{
    public class Hero : Character
    {
        public int ManaPoints { get; }
        // hero may be able to do something different to a monster?
        // however any functions associated with the character should not be contained within this class, it only should be responsible for the fields
        // things like damage calculation need to abstracted into their own class (in the helpers)

        // a character has a special ability (composition?)

        public Hero(string name, int hitPoints, int manaPoints, int baseAttackDamage) : base(name, hitPoints, baseAttackDamage)
        {
            ManaPoints = manaPoints;
        }

        // eventually these values will be decided by class that the user selects
    }
}
