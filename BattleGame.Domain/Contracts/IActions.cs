using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Contracts
{
    public interface IActions
    {
        int Attack(ICharacter character);
        int Block(int attackDamage);
        void CastSpell();
        void UseItem();
    }
}
