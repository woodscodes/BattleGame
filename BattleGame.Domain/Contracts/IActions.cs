using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Contracts
{
    public interface IActions
    {
        int Attack();
        void Block();
        void CastSpell();
        void UseItem();
    }
}
