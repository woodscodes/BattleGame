using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.UI.Contracts
{
    public interface IDisplay
    {
        string Display(ICharacter character);
    }
}
