using BattleGame.Domain.Contracts;
using BattleGame.UI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.UI.Helpers
{
    public class DisplayStats : IDisplay
    {
        public string Display(ICharacter character)
        {
            return $"{character.Name} has {character.HitPoints} remaining.";
        }    
    }
}
