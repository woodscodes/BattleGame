using BattleGame.Domain.Contracts;
using BattleGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Helpers
{
    public class DecrementStats
    {
        public static ICharacter DecrementHealthPoints(ICharacter character, int damagedInflicted)
        {
            character.HitPoints -= damagedInflicted;
            return character;
        }

        public static ICharacter DecrementManaPoints(ICharacter character)
        {
            character.ManaPoints--;
            return character;
        }
    }
}
