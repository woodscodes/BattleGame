﻿using BattleGame.Domain.Contracts;
using BattleGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame.Domain.Helpers
{
    public class DecrementStats : IDecrementStats
    {
        public ICharacter DecrementHealthPoints(ICharacter character, int damagedInflicted)
        {
            character.HitPoints -= damagedInflicted;
            return character;
        }

        public ICharacter DecrementManaPoints(ICharacter character)
        {
            character.HitPoints--;
            return character;
        }
    }
}
