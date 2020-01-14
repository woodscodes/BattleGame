using BattleGame.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Engine
{
    public class RoundStats
    {
        public static string ShowDamage(string characterName, int DamageInflicted)
        {
            return $"{characterName} inflicted {DamageInflicted}DMG";
        }

        public static string ShowStatus(ICharacter character)
        {
            return $"{character.Name} has {character.HitPoints}HP remaining";
        }
    }
}
