using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Engine
{
    public class RoundActions : IRoundActions
    {
        // singleton practice
        // public static readonly RoundActions Instance = new RoundActions(); use singleton in the battleEngine instantiation?
        private readonly IChanceActions _chanceActions;

        public RoundActions(IChanceActions chanceActions)
        {
            _chanceActions = chanceActions;
        }

        public int Attack(ICharacter character)
        {
            return (int)_chanceActions.RollForAttackDamage(character.BaseAttackDamage);
        }

        public int Block(int damageRecieved)
        {
            return (int)_chanceActions.RollForBlock(damageRecieved);
        }

        public void CastSpell()
        {
            // casting spells would require a list of spells available to the character, and the selected one would be returned here along with damage (smelly? doing two things)
        }

        public void UseItem()
        {
            // using items would require a list of items available to the character, return it and apply its affects... (Maybe better to to GetItem and UseItem as two sepearate actions)
        }

    }
}
